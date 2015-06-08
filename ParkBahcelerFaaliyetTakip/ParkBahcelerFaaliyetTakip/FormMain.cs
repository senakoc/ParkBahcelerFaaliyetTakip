using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabaseAccessLayer;
using DatabaseAccessValues;

using System.IO;
using System.Xml;

namespace ParkBahcelerFaaliyetTakip
{
    public partial class FormMain : Form
    {
        #region Global Değişkeler 
        //database ierişimi için gerekli değişkenler
        private myDatabaseAccess databaseAccess = null;
        public string databaseName = string.Empty;//(ReportForm,AddForm
        private DataTable dt = null;

        public string tableName = string.Empty;//datagridview'e yüklenen tablo ismini tutucak(ReportForm,AddForm
        public string kayitGiren = string.Empty;

        private List<string> dataRowList = null;

        //checkbox olayları için
        private bool clickedAllselected = false;
        private int maxClickedItems = 0;
        private int minClickedItems = 0;
        private List<int> clickedItems = null;

        //timer labeli için
        private int timerCount = 3;
        private bool isSelectedTable = false;// tablo seçmemişse
        private bool connectedDatabaseFail = false;//database ile bagşantı kuruldumu
        private bool gotTablesNamesFail = false;//tablo isimleri databaseden alındımı
        private bool loadedDataSourceFail = false;//tablo datagridviewe yüklendimi
        private bool deletedAllFail = false;//tüm secilenler silindimi
        private bool noItemsSelected = false; // herhangi bi kayıt seçilmişmi
        private bool deleteTableFail = false;
        private bool deleteTableSuccessful = false;
        
        //datagrdiviewcellstyle + font
        public DataGridViewCellStyle newStyle = null;
        public DataGridViewCellStyle defaultStyle = null;
        public DataGridViewCellStyle Columnstyle = null;
        
        public System.Drawing.Font ROWfont;
        public Color ROWforecolor;
        public Color ROWbackColor;

        public System.Drawing.Font COLUMNfont;
        public Color COLUMNforecolor;
        public Color COLUMNbackColor;


        //Formlar
        private FormAdd add = null;
        private FormEdit edit = null;
        private FormAddTable addTable = null;
        private FormReport report = null;
        private FormSettings settings = null;
        #endregion Global END

        #region 1. FormMain
        public FormMain()
        {
            #region Formlar
            add = new FormAdd();
            add.main = this;

            edit = new FormEdit();
            edit.main = this;

            report = new FormReport();
            report.main = this;

            settings = new FormSettings();
            settings.main = this;
            #endregion

            InitializeComponent();
    
            CheckBoxAllSelect.Checked = false;

            xmlReader();

            #region satır stili
            defaultStyle = new DataGridViewCellStyle();
            defaultStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            defaultStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            defaultStyle.Font = ROWfont;
            defaultStyle.ForeColor = ROWforecolor;
            defaultStyle.BackColor = ROWbackColor;
            defaultStyle.SelectionBackColor = ROWbackColor;
            defaultStyle.SelectionForeColor = ROWforecolor;
            #endregion

            #region kolon stili
            Columnstyle = dataGridView1.ColumnHeadersDefaultCellStyle;
            Columnstyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Columnstyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Columnstyle.Font = COLUMNfont;
            Columnstyle.BackColor = COLUMNbackColor;
            Columnstyle.ForeColor = COLUMNforecolor;
            Columnstyle.SelectionBackColor = COLUMNbackColor;
            Columnstyle.SelectionForeColor = COLUMNforecolor;
            #endregion

            #region üzeri çizili stil
            newStyle = new DataGridViewCellStyle();
            newStyle.Font = ROWfont;
            newStyle.ForeColor = Color.Red;
            newStyle.BackColor = Color.LemonChiffon;
            newStyle.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            newStyle.SelectionForeColor = System.Drawing.Color.Red;
            newStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            newStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            #endregion

            //eventler
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(silRowClick);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(hucreTemizle);
            CheckBoxAllSelect.MouseClick += new MouseEventHandler(allRowSelected);
        }
        #endregion 1. END

        #region 2. FormMain Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckBoxAllSelect.Visible = false;//tümünü seç görünmesin
            
            databaseAccess = new myDatabaseAccess();
            if (databaseAccess.ConnectionDatabase(new connectionValues() { Server = "SENAPC", Database = "faaliyetler" }))
            {
                databaseName = "faaliyetler";
                ToolStripMenuItemAdd();//tablo isimleri tablolar sekmesine ekleniyor
            }
            else
            {
                connectedDatabaseFail = true;
                timer1.Enabled = true;//kullanıcıyı bilgilendirmek için timer aktif ediliyor
            }
        }
        #endregion '. END

        #region 3. Tablo isimlerinin yüklenmesi ve Tablo seçme olayı 
       
        #region 3.1. tablo isimlerinin Tablolar menusune eklenmesi 
        public void ToolStripMenuItemAdd() // (FormAddTable
        {
            ToolStripMenuItemTablolar.DropDownItems.Clear();//önceki eklemeler temizleniyor
            dataRowList = new List<string>();
            dataRowList = databaseAccess.getDatareaderDataList("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME not like( 'sysdiagrams')");
            if (dataRowList != null)
            {
                foreach (string tableName in dataRowList)
                {
                    ToolStripMenuItemTablolar.DropDown.Items.Add(tableName, null, new EventHandler(selectedItem));
                }
            }
            else
            {
                gotTablesNamesFail = true;
                timer1.Enabled = true;//kullanıcıyı bilgilendirmek için timer aktif ediliyor
            }           
        }
        #endregion 3.1. END

        #region 3.2. tablo seçme
        private void selectedItem(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            tableName = clickedItem.Text.Trim();
            isSelectedTable = true;
            loadTable();//seçilen tabloyu datagridviewe yükle
        }
        #endregion 3.2. END

        #endregion 3. END

        #region  4. Datagridview datasource
        public void loadTable()
        {
            dataGridView1.Columns.Clear();//önceki kolonlar temizlensin
            if (isSelectedTable)
            {
                CheckBoxAllSelect.Visible = true;
                dt = databaseAccess.getDatagridDatasource(databaseName,tableName);
                if (dt != null)
                {
                    dataGridView1.DefaultCellStyle = defaultStyle;
                    dataGridView1.ColumnHeadersDefaultCellStyle = Columnstyle;

                    dataGridView1.DataSource = dt;
                    if (dataGridView1.RowCount == 0)//tüm kayıt silinmişse
                    {
                        databaseAccess.executeQuery("DBCC CHECKIDENT ('[" + databaseName + "].[dbo].[" + tableName + "]', RESEED,0)");
                    }
                    dt.Columns.Add("Sil", System.Type.GetType("System.Boolean"));//checkbox kolonu
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        col.ReadOnly = true;
                        if (col.HeaderText == "Sil")
                        {
                            dataGridView1.Columns["Sil"].ReadOnly = false;
                        }
                    }
                    maxClickedItems = dataGridView1.RowCount;
                    minClickedItems = 0;

                    CheckBoxAllSelect.Checked = false;

                    clickedItems = new List<int>();

                }
                else
                {
                    loadedDataSourceFail = true;
                    timer1.Enabled = true;
                }
                
            }
        }
        #endregion 4. END

        #region 5. Chechbox Olayları 

        #region 5.1. silmek için kutucuk seçilmesi eventi
        private void silRowClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!clickedAllselected)//tümünüseç seçilmemişse 
            {
                silClickActions((DataGridViewCheckBoxCell)dataGridView1[e.ColumnIndex, e.RowIndex]);
            }
        }
        #endregion 5.2. END
 
        #region 5.2. silinecek satır işlemleri
        private void silClickActions(DataGridViewCheckBoxCell RCheckBox)
        {
            bool checkedBox = bool.Parse(dataGridView1.CurrentRow.Cells["Sil"].Value.ToString());
            if (dataGridView1.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                if (checkedBox)
                {
                    minClickedItems++;//sil kutuları yıklandıkça artar
                    clickedItems.Add((int)dataGridView1["KayitNo", RCheckBox.RowIndex].Value);//check edilen kolonun hayit numarası clickedItems nesnesine eklenir
                    foreach (DataGridViewCell cell in dataGridView1.CurrentRow.Cells)
                    {
                        cell.Style = newStyle;//tıklanana satırın tüm hücreleri yeni stille eşitlenir
                    }
                }
                else if (!checkedBox)
                {
                    minClickedItems--;
                    clickedItems.Remove((int)dataGridView1["KayitNo", RCheckBox.RowIndex].Value);
                    foreach (DataGridViewCell cell in dataGridView1.CurrentRow.Cells)
                    {
                        cell.Style = defaultStyle;
                    }
                }
            }
            if (minClickedItems == maxClickedItems)
            {
                CheckBoxAllSelect.Checked = true;//yalnızca tıklanmış görünür evet çağrılmaz
            }
            else if (minClickedItems != maxClickedItems)
            {
                CheckBoxAllSelect.Checked = false;
            }
        }
        #endregion 5.3. END

        #region 5.3. tümünü seç chechkboxununu seçilmesi
        private void allRowSelected(object sender, MouseEventArgs e)
        {
            allRowActions((CheckBox)sender);
        }
        #endregion 5.3. END

        #region 5.4. tümünü seçince gerçekleşecek işlemler
        private void allRowActions(CheckBox HCheckBox)
        {
            clickedAllselected = true; //true olduğu için silClickAction eventine giremicek
            clickedItems.Clear();//tümü eklenenler temizlenir
            foreach (DataGridViewRow row in dataGridView1.Rows)//tüm satırları geziyor
            {
                ((DataGridViewCheckBoxCell)row.Cells["Sil"]).Value = CheckBoxAllSelect.Checked;// CheckBoxAllSelectin checked durumu her sil kutularına uygulanıyo
                foreach (DataGridViewCell cell in row.Cells)//her satırın hücresini dolaşıyır
                {
                    cell.Style = CheckBoxAllSelect.Checked ? newStyle : defaultStyle;//hücrelerin stilleri CheckBoxAllSelect seçilmişse yeni stil seçilmemişse default stile eşitlenir
                }
                if (HCheckBox.Checked)
                {
                    clickedItems.Add((int)dataGridView1["KayitNo", row.Index].Value);//her kayitno numarası clickedItemse ekleniyor.
                }
            }
        }
        #endregion 5.4. END

        #region 5.5. yapılan değişikliklerin hemen görüntülenmesi içi
        private void hucreTemizle(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        #endregion 5.5.END
       
        #endregion 5. END

        #region 6. Sil butonu olayı
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string sorgu = "";
            List<int> silinemeyenler = new List<int>();
            if (isSelectedTable)
            {
                if (clickedItems.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Seçili kayıtları silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var item in clickedItems)//tüm seçilen kayit numaralarını tek tek dolaşıo
                        {
                            sorgu = "DELETE FROM [" + databaseName + "].[dbo].[" + tableName + "] WHERE [KayitNo] = " + item + "";
                            if (databaseAccess.executeQuery(sorgu) == 0)
                            {
                                silinemeyenler.Add(item);
                            }
                        }
                        if (silinemeyenler.Count != 0)//tümü silinememişse bilgilendirme
                        {
                            deletedAllFail = true;
                            timer1.Enabled = true;
                        }
                        loadTable();
                    } 
                }
                else if (clickedItems.Count == 0)
                {
                     noItemsSelected = true;
                     timer1.Enabled = true; 
                }
                
            }
            else if (!isSelectedTable)// tablo seçilmemiş yada silinecek seçilmemişse bilgilendirme
            {
                isSelectedTable = false;
                timer1.Enabled = true;
            }
        }
        #endregion 6. END

        #region 7. Yeni kayıt ekleme olayı 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (isSelectedTable)
            {
                add.ShowDialog();
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion 7 .END

        #region 8. Kayıt düzenleme olayı 
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (isSelectedTable)
            {
                edit.ShowDialog();
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion 8 .END

        #region 9. Yeni tablo oluşturma olayı 
        private void ButtonNewTable_Click(object sender, EventArgs e)
        {
            addTable = new FormAddTable();
            addTable.main = this;
            addTable.Show();
        }
        #endregion 9. ENd

        #region 10. Tabloyu silme olayı 
        private void ButtonTableDelete_Click(object sender, EventArgs e)
        {
            if (isSelectedTable)
            {
                DialogResult sonuc = MessageBox.Show("Tablo Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    String sorgu = "DROP TABLE " + tableName + "";
                    int a = databaseAccess.executeQuery(sorgu);
                    if (a!=0)
                    {
                        tableName = string.Empty;
                        loadTable();
                        ToolStripMenuItemAdd();
                        deleteTableSuccessful = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        deleteTableFail = true;
                        timer1.Enabled = true;
                    }

                }
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion 10 .END

        #region 11. Excele aktarma olayı 
        private void ToolStripMenuItemExcel_Click(object sender, EventArgs e)
        {
            if (isSelectedTable)
            {
                Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                uyg.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

                for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                    myRange.Value2 = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                        myRange.Value2 = dataGridView1[i, j].Value;
                    }
                }
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion 11. END

        #region 13. Rapor oluşturma olayı
        private void ToolStripMenuItemRapor_Click(object sender, EventArgs e)
        {
            if (isSelectedTable)
            {
                report.ShowDialog();
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        #endregion

        #region 15. Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 1. Veritabanına bağlanılamadıysa
            if (connectedDatabaseFail)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Veri tabanına bağlanılamadı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 0;
                    connectedDatabaseFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1. END

            #region 2. Tablo isimleri alınamadıysa
            else if (gotTablesNamesFail)
            {
                 if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo isimleri veritabanından alınamadı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    gotTablesNamesFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 2.END

            #region 3. Datatable datagride yüklenemediyse
            else if (loadedDataSourceFail)
            {
                 if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo yüklenemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    loadedDataSourceFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 3. END

            #region 4. Seçilen kayıtlardan bazıları silinmediyse
            else if (deletedAllFail)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Seçilen kayıtlardan bazıları silinemedi..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    deletedAllFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 4. END

            #region 5. seçim yapmadan silmeye çalışıyosa
            else if (noItemsSelected)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Önce kayıt seçmelisiniz..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    noItemsSelected = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 5.END
               
            #region 6. Tablo seçimi yapmadıysa
            else if (!isSelectedTable)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo seçmelisiniz..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 6. END

            #region  7. Tablo silinemediyse
            else if (deleteTableFail)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo silinemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    deleteTableFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 7. END

            #region 8. Tablo silindiyse
            else if (deleteTableSuccessful)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo silindi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    deleteTableSuccessful = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 8 .END
        }
        #endregion

        #region 16. Diğer formlar için sql
      
        //1.
        public List<string> getReaderList(string query) { return databaseAccess.getDatareaderDataList(query); } //(ReportForm ,FormAdd, FormEdit
        //2.
        public DataTable getDataTableForQuery(string query) { return databaseAccess.getDataTable(query); } //(Report Form
        //3.
        public object getScalarQuery(string query) { return databaseAccess.executeScalarQuery(query); } //(Report Form
        //4.
        public int getExectuQuery(string query) { return databaseAccess.executeQuery(query); } //(Add Form,FormAddTable
        
        #endregion 16. END
        
        private void button1_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
            if (settings.exsistChanged)
            {
                xmlReader();
            }
        }

        private void xmlReader()
        {
            XmlTextReader reader = new XmlTextReader("Settings.xml");

            XmlNodeType type;
            while (reader.Read())
            {
                type = reader.NodeType;
                if (type == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "KISI":
                            {
                                reader.Read();
                                kayitGiren = reader.Value.ToString();
                                break;
                            }
                        case "FONTROW":
                            {
                                reader.Read();
                                TypeConverter tc = TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
                                System.Drawing.Font newFont = (System.Drawing.Font)tc.ConvertFromString(reader.Value.ToString());
                                ROWfont = newFont;
                                break;
                            }
                        case "FONTROWFORECOLOR":
                            {
                                reader.Read();
                                int argb = Convert.ToInt32(reader.Value.ToString());
                                ROWforecolor = Color.FromArgb(argb);
                                break;
                            }
                        case "FONTROWBACKCOLOR":
                            {
                                reader.Read();
                                int argb = Convert.ToInt32(reader.Value.ToString());
                                ROWbackColor = Color.FromArgb(argb);
                                break;
                            }
                        case "FONTCOLUMN":
                            {
                                reader.Read();
                                TypeConverter tc = TypeDescriptor.GetConverter(typeof(System.Drawing.Font));
                                System.Drawing.Font newFont = (System.Drawing.Font)tc.ConvertFromString(reader.Value.ToString());
                                COLUMNfont = newFont;
                                break;
                            }
                        case "FONTCOLUMNFORECOLOR":
                            {
                                reader.Read();
                                int argb = Convert.ToInt32(reader.Value.ToString());
                                COLUMNforecolor = Color.FromArgb(argb);
                                break;
                            }
                        case "FONTCOLUMNBACKCOLOR":
                            {
                                reader.Read();
                                int argb = Convert.ToInt32(reader.Value.ToString());
                                COLUMNbackColor = Color.FromArgb(argb);
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            reader.Close(); 
        }
    }
}
