using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkBahcelerFaaliyetTakip
{
    public partial class FormReport : Form
    {
        #region Global değişkenler
        //sorgu kalıpları
        private string filtreTarih = string.Empty;
        private string filtreMahalle = string.Empty;
        private string filtreCaddeSokakPark = string.Empty;
        private string filtreTurAdi = string.Empty;
        private string filtreKayitGirenKisi = string.Empty;

        //Görüntülenen kolon companentlerini tutcak
        private List<CheckBox> columnsCheck = null;
        private List<string> selectedColumnsNames = null;

        //timer
        private int timerCount = 3;
        private bool loadedColumnsNamesFail = false;//kolon isimleri yüklemesi başarısızmı
        private bool gotmahalleNamesFail = false;//mahalle isimleri alınmasi başarısızmı
        private bool gotCaddeSokakParkNamesFail = false;//caddesokakpark isimleiri alınmasi başarısızmı
        private bool gotTurAdiNamesFail = false;//tur adi isimleri alınmasi başarısızmı
        private bool gotKayitGirenKisiNamesFail = false;//kayıtgirenkişi isimleri alınmasi başarısızmı
        private bool loadedTableFail = false;// tablo yüklendimesi başarısızmı
        private bool sumColumnsFail = false; // kolonlar toplandımı
        private string toplanamayanKolonlar = string.Empty;
        private bool loadedRapor = false;
        private bool loadedRaporFail = false;
        //excel
        private enum mounts {Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık };
        private string[] ay = Enum.GetNames(typeof(mounts));
        private List<int> columnsIndexs = null;
        private List<int> selectedColumsIndexs = null;
        private bool filtreYok = false;
        static int satir;//excel

        DateTime timeStarted;
        TimeSpan finished;

        public FormMain main;
        #endregion

        #region 1. FormReport
        public FormReport()
        {            
            InitializeComponent();
        }
        #endregion  1.______________________

        #region 2. FormReport Load
        private void FormReport_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAyarlar; // Rapor ayarları sekmesiyle açılsın form

            enableFalse();//tüm comboboxlar temizleniyor enable false yapılıyor ve datetime checked false yapılıyor

            if (!loadFormsCompanents())//kompanentler yüklenirken bir hata oluşursa
            {
                loadedColumnsNamesFail = true;
                timer1.Enabled = true;
            }
        }
        #endregion 2.______________________

        #region 3. Görüntülecek dinamik elemanlar

        #region 3.1. Komponentlerin oluşturulması
        private bool loadFormsCompanents() 
        {
            groupBoxKolonlar.Controls.Clear();//önceden eklenmiş kolon isimleri temizleniyor
            checkedListBox1.Items.Clear(); // önceden eklenmiş checkedlist elemanları temizleniyor
            try
            {
                #region formun yüklenmesi
                columnsCheck = new List<CheckBox>();
                selectedColumnsNames = new List<string>();
                columnsIndexs = new List<int>();
                for (int i = 1; i < main.dataGridView1.ColumnCount-1; i++)//datagrid kolonlarını dolaşcak satır no alınmıcak ve sil kolonu alınmicak
                {
                    #region checkbox kolonları
                    CheckBox checkKolon = new CheckBox();
                    checkKolon.AutoSize = true;
                    checkKolon.Location = new System.Drawing.Point(30, (i * 60));
                    checkKolon.Size = new System.Drawing.Size(98, 21);
                    checkKolon.Text = main.dataGridView1.Columns[i].HeaderText.ToString();
                    checkKolon.Checked = true;
                    checkKolon.CheckedChanged += new EventHandler(checkBoxKolon_Checked);

                    columnsCheck.Add(checkKolon);
                    groupBoxKolonlar.Controls.Add(checkKolon);
                    #endregion

                    #region Toplanabilir kolonlar Deneme işlemi düzenlencek**********
                    if (main.dataGridView1.Columns[i].ValueType == typeof(int))
                    {
                        if (main.dataGridView1.Columns[i].Name != "KayitNo")
                        {
                            columnsIndexs.Add(main.dataGridView1.Columns[i].Index);
                            checkedListBox1.Items.Add(main.dataGridView1.Columns[i].HeaderText);
                        }
                    }
                    #endregion

                    #region Combobox itemlerinin yüklenmesi
                    #region mahalle
                    if (main.dataGridView1.Columns[i].HeaderText.Equals("Mahalle"))
                    {
                        comboBoxMahalle.Enabled = true;
                        object returnObject = main.getReaderList("SELECT DISTINCT [Mahalle] FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "]");
                        if (returnObject != null)
                        {
                            foreach (string item in (List<String>)returnObject)
                            {
                                comboBoxMahalle.Items.Add(item.ToString());
                            }
                        }
                        else//timer çalışcak
                        {
                            gotmahalleNamesFail = true; // mahalle isimleri alınamadı
                            timer1.Enabled = true;
                        }
                    }
                    #endregion

                    #region CaddeSokakPark
                    if (main.dataGridView1.Columns[i].HeaderText.Equals("CaddeSokakPark"))
                    {
                        comboBoxCaddeSokakPark.Enabled = true;
                        object returnObject = main.getReaderList("SELECT DISTINCT [CaddeSokakPark] FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "]");
                        if (returnObject != null)
                        {
                            foreach (string item in (List<String>)returnObject)
                            {
                                comboBoxCaddeSokakPark.Items.Add(item.ToString());
                            }
                        }
                        else//timer çalışcak
                        {
                            gotCaddeSokakParkNamesFail = true; // cadde isimleri alınamadı
                            timer1.Enabled = true;
                        }
                    }
                    #endregion

                    #region Tür adları
                    if (main.dataGridView1.Columns[i].HeaderText.Equals("TurAdi"))
                    {
                        comboBoxTurAdi.Enabled = true;
                        object returnObject = main.getReaderList("SELECT DISTINCT [TurAdi] FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "]");
                        if (returnObject != null)
                        {
                            foreach (string item in (List<String>)returnObject)
                            {
                                comboBoxTurAdi.Items.Add(item.ToString());
                            }
                        }
                        else//timer çalışcak
                        {
                            gotTurAdiNamesFail = true; // türadları isimleri alınamadı
                            timer1.Enabled = true;
                        }
                    }
                    #endregion

                    #region Kayıt girenler
                    if (main.dataGridView1.Columns[i].HeaderText.Equals("KaydiGirenKisi"))
                    {
                        comboBoxKayıtGirenler.Enabled = true;
                        object returnObject = main.getReaderList("SELECT DISTINCT [KaydiGirenKisi] FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "]");
                        if (returnObject != null)
                        {
                            foreach (string item in (List<String>)returnObject)
                            {
                                comboBoxKayıtGirenler.Items.Add(item.ToString());
                            }
                        }
                        else//timer çalışcak
                        {
                            gotKayitGirenKisiNamesFail = true; // türadları isimleri alınamadı
                            timer1.Enabled = true;
                        }
                    }
                    #endregion

                    if (main.dataGridView1.Columns[i].ValueType == typeof(System.DateTime))
                    {
                        dateTimePickerBaslangıc.Enabled = true;
                        dateTimePickerBitis.Enabled = true;
                    }
                    #endregion
                }
                selectedColumnsNames.Clear();//önceden kalmışsa temizlensin
                selectedColumnsNamesLoad(); //seçililerin hepsi yüklensin
                return true;
                #endregion
            }
            catch (Exception)
            {
                return false;
            }           
        }
        #endregion

        #region 3.2. Combobox ve timepicker enable false yapılıyor ve Combobox itemleri temizleniyor
        private void enableFalse() 
        {
            comboBoxMahalle.Enabled = false;
            comboBoxMahalle.Items.Clear();

            comboBoxCaddeSokakPark.Enabled = false;
            comboBoxCaddeSokakPark.Items.Clear();

            comboBoxTurAdi.Enabled = false;
            comboBoxTurAdi.Items.Clear();

            comboBoxKayıtGirenler.Enabled = false;
            comboBoxKayıtGirenler.Items.Clear();

            dateTimePickerBaslangıc.Enabled = false;
            dateTimePickerBaslangıc.Checked = false;

            dateTimePickerBitis.Enabled = false;
            dateTimePickerBitis.Checked = false;
        }
        #endregion

        #region 3.3 kolon isimleri checkboxlarının tıklanması
        private void checkBoxKolon_Checked(object sender, EventArgs e)
        {
            selectedColumnsNames.Clear();
            selectedColumnsNamesLoad();
        }
        #endregion

        #region 3.4 Seçilen kolon isimlerinin list tipindeki nesneye aktarılması
        private void selectedColumnsNamesLoad() 
        {
            for (int i = 0; i < columnsCheck.Count; i++)// tüm list checkbox taki checkboxları dolaşıyor
            {
                if (columnsCheck[i].Checked == false)
                {
                    selectedColumnsNames.Remove(columnsCheck[i].Text.ToString());
                }
                else
                    selectedColumnsNames.Add(columnsCheck[i].Text.ToString());
            }
        }
        #endregion
       
        #endregion 3. __________________________________

        #region 4. Rapor sekmesinin seçilmesi
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text.Equals("Rapor"))//rapor sekmesi tıklanmışsa
            {
                #region Sorgunun Select parçası
                string sorguSelect = "SELECT ";
                for (int i = 0; i < selectedColumnsNames.Count; i++)
                {
                    sorguSelect += "[" + selectedColumnsNames[i] + "]";
                    if (i != selectedColumnsNames.Count - 1)
                    {
                        sorguSelect += ", ";
                    }
                }
                #endregion

                #region Tarih Filtresi
                string tarihWhere = "";
                if ((dateTimePickerBaslangıc.Checked) && (dateTimePickerBitis.Checked))
                {
                    tarihWhere = "[Tarih] BETWEEN '" + dateTimePickerBaslangıc.Text.ToString() + "' AND '" + dateTimePickerBitis.Text.ToString() + "'";
                }
                else if (dateTimePickerBaslangıc.Checked)
                {
                    tarihWhere = "[Tarih] = '" + dateTimePickerBaslangıc.Text.ToString() + "'";
                }

                else if (dateTimePickerBitis.Checked)
                {
                    tarihWhere = "[Tarih] = '" + dateTimePickerBitis.Text.ToString() + "'";
                }
                #endregion

                #region Comboboxların filtresi
                string comboBoxWhere = "";
                if (comboBoxMahalle.SelectedIndex != -1)
                {
                    comboBoxWhere += "[Mahalle] like ('" + comboBoxMahalle.Text.ToString() + "')";
                    if ((comboBoxCaddeSokakPark.SelectedIndex != -1) || (comboBoxTurAdi.SelectedIndex != -1) || (comboBoxKayıtGirenler.SelectedIndex != -1))
                    {
                        comboBoxWhere += " AND ";
                    }
                }
                if (comboBoxCaddeSokakPark.SelectedIndex != -1)
                {
                    comboBoxWhere += "[CaddeSokakPark] like ('" + comboBoxCaddeSokakPark.Text.ToString() + "')";
                    if ((comboBoxTurAdi.SelectedIndex != -1) || (comboBoxKayıtGirenler.SelectedIndex != -1))
                    {
                        comboBoxWhere += " AND ";
                    }
                }
                if (comboBoxTurAdi.SelectedIndex != -1)
                {
                    comboBoxWhere += "[TurAdi] like ('" + comboBoxTurAdi.Text.ToString() + "')";
                    if (comboBoxKayıtGirenler.SelectedIndex != -1)
                    {
                        comboBoxWhere += " AND ";
                    }
                }
                if (comboBoxKayıtGirenler.SelectedIndex != -1)
                {
                    comboBoxWhere += "[KaydiGirenKisi] like ('" + comboBoxKayıtGirenler.Text.ToString() + "')";
                }
                #endregion

                #region Sorgunun Where Parçası
                string sorguWhere = "";
                if ((comboBoxWhere != "") || (tarihWhere != ""))
                {
                    sorguWhere += " WHERE ";
                    if (comboBoxWhere != "")
                    {
                        sorguWhere += comboBoxWhere;
                        if (tarihWhere != "")
                        {
                            sorguWhere += " AND ";
                        }
                    }
                    if (tarihWhere != "")
                    {
                        sorguWhere += tarihWhere;
                    }
                }
                if (sorguWhere == "")
                {
                    filtreYok = true; // where sorgu cümleciği sorguda yokmuş
                }
                else if (sorguWhere != "")
                {
                    filtreYok = false;
                }
                #endregion

                #region Datagride tablonun yüklenmesi
                Object resultObj = main.getDataTableForQuery(sorguSelect + " FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "] " + sorguWhere);
                if (resultObj != null)
                {
                    dataGridView1.DataSource = (DataTable)resultObj;
                    satir = dataGridView1.RowCount;
                }
                else
                {
                    loadedTableFail = true;
                    timer1.Enabled = true;
                }
                #endregion

                #region Toplam işleminin yapılması
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    listBox1.Items.Clear();//önceden yüklenmişler temizlensin
                    toplanamayanKolonlar = "";
                    int genelToplam = 0;
                    selectedColumsIndexs = new List<int>();
                    foreach (int i in checkedListBox1.CheckedIndices)
                    {
                        selectedColumsIndexs.Add(columnsIndexs[i]);
                    }
                    foreach (object itemChecked in checkedListBox1.CheckedItems)
                    {
                        string sorguSum = "SELECT SUM([" + itemChecked.ToString() + "]) FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "]";
                        if (sorguWhere != "")//eğer özellikle bi bölgede toplama yapılcaksa
                        {
                            sorguSum += sorguWhere;
                        }
                        object resultScalar = main.getScalarQuery(sorguSum);
                        if (resultScalar != null)
                        {
                            listBox1.Items.Add("Toplam " + itemChecked.ToString() + " : " + resultScalar.ToString());
                            genelToplam += (int)resultScalar;
                        }
                        else
                        {
                            toplanamayanKolonlar += itemChecked.ToString() + " ";
                        }
                    }
                    if (checkedListBox1.CheckedItems.Count >= 2)
                    {
                        listBox1.Items.Add("Tüm Toplam : " + genelToplam.ToString());
                    }

                    if (toplanamayanKolonlar != "")
                    {
                        sumColumnsFail = true;
                        timer1.Enabled = true;
                    }
                }
                #endregion
            }
            else if (e.TabPage.Text.Equals("Rapor Ayarları"))
            {
                listBox1.Items.Clear();
                dataGridView1.Columns.Clear();
            }
        }
        #endregion 4. __________________________________

        #region 5. Raporu excele aktarma
        private void raporuExceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                timeStarted = DateTime.Now;
                Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                uyg.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook Faaliyetler = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)Faaliyetler.Sheets[1];

                if (comboBoxMahalle.Text != "")
                {
                    sheet1.Name = comboBoxMahalle.Text;
                }
                else
                {
                    sheet1.Name = main.tableName;
                }
                #region Tablonun Excele Aktarılması
                //kolon isimleri yükleniyor
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                    myRange.Value2 = dataGridView1.Columns[i].HeaderText;

                    myRange.Font.Name = "Candara";
                    myRange.Font.Size = 12;
                    myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    myRange.Rows.RowHeight = 26;
                    myRange.ColumnWidth = 26;
                    myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    myRange.Cells.Borders.Weight = 2D;
                    myRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LemonChiffon);
                }

                //satır değerleri yükleniyor
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];

                        if (dataGridView1[i, j].ValueType == typeof(System.DateTime))// tarih kolonu için düzenleme
                        {
                            string a = dataGridView1[i, j].Value.ToString();
                            string[] s = a.Split('.');
                            int ayNumarası = Convert.ToInt32(s[1]) % 13;

                            string[] yıl = s[2].Split(' ');
                            myRange.Value2 = s[0] + " " + ay[ayNumarası - 1] + " " + yıl[0];
                        }
                        else
                        {
                            myRange.Value2 = dataGridView1[i, j].Value;
                        }

                        myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        myRange.Cells.Borders.Weight = 2D;
                        myRange.Rows.RowHeight = 20;
                        myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                }
                #endregion

                #region ListBoxun Excele Aktarılması
                if (checkedListBox1.CheckedItems.Count != 0) // bişe toplanmamışsa listbox boş demek
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)//her listbox itemini dolaşcak
                    {
                        if (i != listBox1.Items.Count - 1)//genel toplama gelmemiş demeztir
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[dataGridView1.RowCount + 2, selectedColumsIndexs[i]];
                            myRange.Value2 = listBox1.Items[i].ToString();

                            myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            myRange.Cells.Borders.Weight = 2D;

                            myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                            myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        }
                        else
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[dataGridView1.RowCount + 3, dataGridView1.ColumnCount / 2];
                            myRange.Value2 = listBox1.Items[i].ToString();

                            myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            myRange.Cells.Borders.Weight = 2D;

                            myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                            myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        }
                    }
                }
                #endregion

                #region Herhangi bi filtre yoksa toplonun mahalle tür alanlarının grouplanıp excele aktarılması
                if (filtreYok)
                {
                    #region Mahalle group by
                    if (comboBoxMahalle.Enabled)
                    {
                        string sorguGroupBy = "SELECT";
                        sorguGroupBy += " [Mahalle] ,COUNT(*) AS ADET,";
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            string sum = checkedListBox1.Items[i].ToString();
                            sorguGroupBy += "SUM ([" + sum + "]) AS Toplam" + sum + "";
                            if (i != checkedListBox1.Items.Count - 1)
                            {
                                sorguGroupBy += ", ";
                            }
                        }
                        sorguGroupBy += " FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "] Group BY [Mahalle]";

                        Object resultObj = main.getDataTableForQuery(sorguGroupBy);
                        if (resultObj != null)
                        {
                            int i = 0;
                            foreach (DataColumn column in ((DataTable)resultObj).Columns)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[dataGridView1.RowCount + 5, 2 + i];
                                myRange.Value2 = column.ColumnName.ToString();
                                myRange.Font.Name = "Candara";
                                myRange.Font.Size = 12;
                                myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.Rows.RowHeight = 26;
                                myRange.ColumnWidth = 26;
                                myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                myRange.Cells.Borders.Weight = 2D;
                                myRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LemonChiffon);
                                i++;
                            }
                            int r = 0;
                            foreach (DataRow row in ((DataTable)resultObj).Rows)
                            {
                                int k = 0;
                                foreach (DataColumn column in ((DataTable)resultObj).Columns)
                                {
                                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[dataGridView1.RowCount + 6 + r, k + 2];//satır-kolon
                                    myRange.Value2 = row[column].ToString();
                                    myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    myRange.Cells.Borders.Weight = 2D;
                                    myRange.Rows.RowHeight = 20;
                                    myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    k++;
                                }
                                r++;
                            }
                            satir += (6 + r);
                        }
                    }
                    #endregion

                    #region Tür adi gruplaması
                    if (comboBoxTurAdi.Enabled)
                    {
                        int turSatir = satir;
                        turSatir += 5;
                        string sorguGroupBy = "SELECT";
                        sorguGroupBy += " [TurAdi] ,COUNT(*) AS ADET,";
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            string sum = checkedListBox1.Items[i].ToString();
                            sorguGroupBy += "SUM ([" + sum + "]) AS Toplam" + sum + "";
                            if (i != checkedListBox1.Items.Count - 1)
                            {
                                sorguGroupBy += ", ";
                            }
                        }
                        sorguGroupBy += " FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "] Group BY [TurAdi]";

                        Object resultObj = main.getDataTableForQuery(sorguGroupBy);
                        if (resultObj != null)
                        {
                            int i = 0;
                            foreach (DataColumn column in ((DataTable)resultObj).Columns)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[turSatir, 2 + i];
                                myRange.Value2 = column.ColumnName.ToString();
                                myRange.Font.Name = "Candara";
                                myRange.Font.Size = 12;
                                myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.Rows.RowHeight = 26;
                                myRange.ColumnWidth = 26;
                                myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                myRange.Cells.Borders.Weight = 2D;
                                myRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LemonChiffon);
                                i++;
                            }
                            int r = 0;
                            foreach (DataRow row in ((DataTable)resultObj).Rows)
                            {
                                int k = 0;
                                foreach (DataColumn column in ((DataTable)resultObj).Columns)
                                {
                                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[turSatir + 1 + r, k + 2];//satır-kolon
                                    myRange.Value2 = row[column].ToString();
                                    myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    myRange.Cells.Borders.Weight = 2D;
                                    myRange.Rows.RowHeight = 20;
                                    myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    k++;
                                }
                                r++;
                            }
                            satir += 5 + r;
                        }
                    }
                    #endregion

                    #region CaddeSokakPark Group by
                    if (comboBoxCaddeSokakPark.Enabled)
                    {
                        int caddeSatir = satir;
                        caddeSatir += 5;
                        string sorguGroupBy = "SELECT";
                        sorguGroupBy += " [CaddeSokakPark] ,COUNT(*) AS ADET,";
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            string sum = checkedListBox1.Items[i].ToString();
                            sorguGroupBy += "SUM ([" + sum + "]) AS Toplam" + sum + "";
                            if (i != checkedListBox1.Items.Count - 1)
                            {
                                sorguGroupBy += ", ";
                            }
                        }
                        sorguGroupBy += " FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "] Group BY [CaddeSokakPark]";

                        Object resultObj = main.getDataTableForQuery(sorguGroupBy);
                        if (resultObj != null)
                        {
                            int i = 0;
                            foreach (DataColumn column in ((DataTable)resultObj).Columns)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[caddeSatir, 2 + i];
                                myRange.Value2 = column.ColumnName.ToString();
                                myRange.Font.Name = "Candara";
                                myRange.Font.Size = 12;
                                myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.Rows.RowHeight = 26;
                                myRange.ColumnWidth = 26;
                                myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                myRange.Cells.Borders.Weight = 2D;
                                myRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LemonChiffon);
                                i++;
                            }
                            int r = 0;
                            foreach (DataRow row in ((DataTable)resultObj).Rows)
                            {
                                int k = 0;
                                foreach (DataColumn column in ((DataTable)resultObj).Columns)
                                {
                                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[caddeSatir + 1 + r, k + 2];//satır-kolon
                                    myRange.Value2 = row[column].ToString();
                                    myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    myRange.Cells.Borders.Weight = 2D;
                                    myRange.Rows.RowHeight = 20;
                                    myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    k++;
                                }
                                r++;
                            }
                            satir += 5 + r;
                        }
                    }
                    #endregion

                    #region KayıtGirenKisilerinGruplanması
                    if (comboBoxKayıtGirenler.Enabled)
                    {
                        int kaydigirenSatir = satir;
                        kaydigirenSatir += 5;
                        string sorguGroupBy = "SELECT [KaydiGirenKisi] ,COUNT(*) AS ADET FROM [" + main.databaseName + "].[dbo].[" + main.tableName + "] Group BY [KaydiGirenKisi]";

                        Object resultObj = main.getDataTableForQuery(sorguGroupBy);
                        if (resultObj != null)
                        {
                            int i = 0;
                            foreach (DataColumn column in ((DataTable)resultObj).Columns)
                            {
                                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[kaydigirenSatir, 2 + i];
                                myRange.Value2 = column.ColumnName.ToString();
                                myRange.Font.Name = "Candara";
                                myRange.Font.Size = 12;
                                myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                myRange.Rows.RowHeight = 26;
                                myRange.ColumnWidth = 26;
                                myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                myRange.Cells.Borders.Weight = 2D;
                                myRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LemonChiffon);
                                i++;
                            }
                            int r = 0;
                            foreach (DataRow row in ((DataTable)resultObj).Rows)
                            {
                                int k = 0;
                                foreach (DataColumn column in ((DataTable)resultObj).Columns)
                                {
                                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[kaydigirenSatir + 1 + r, k + 2];//satır-kolon
                                    myRange.Value2 = row[column].ToString();
                                    myRange.Cells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                    myRange.Cells.Borders.Weight = 2D;
                                    myRange.Rows.RowHeight = 20;
                                    myRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    myRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                                    k++;
                                }
                                r++;
                            }
                            satir += kaydigirenSatir + r;
                        }
                    }
                    #endregion

                }
                #endregion
                
                finished = DateTime.Now - timeStarted;
                loadedRapor = true;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oluşan hata: \n"+ex.Message);
                loadedRaporFail = true;
                timer1.Enabled = true;                
            }         
        }
        #endregion 

        #region 6. text temizlenmesi
        private void ControlsText_Clear(object sender, EventArgs e)
        {
            comboBoxMahalle.SelectedIndex = -1;
            comboBoxCaddeSokakPark.SelectedIndex = -1;
            comboBoxTurAdi.SelectedIndex = -1;
            comboBoxKayıtGirenler.SelectedIndex = -1;
            dateTimePickerBaslangıc.Checked = false;
            dateTimePickerBitis.Checked = false;
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        #endregion

        #region 7. Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region kolon isimleri yüklenmediyse
            if (loadedColumnsNamesFail)
            {
                if (timerCount != 0 )
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Form nesneleri yüklenemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    loadedColumnsNamesFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion

            #region combobox kolonu verileri çekilmediyse
            else if ((gotmahalleNamesFail) || (gotCaddeSokakParkNamesFail) || (gotTurAdiNamesFail) || (gotKayitGirenKisiNamesFail))
            {
                if (timerCount != 0)
                {
                    string olmayanlar = "";
                    labelMessage.Visible = true;
                    if ((gotmahalleNamesFail))
                    {
                        olmayanlar += " 'Mahalle' ";
                    }
                    if ((gotCaddeSokakParkNamesFail))
                    {
                        olmayanlar += " 'CaddeSokakPark' ";
                    }
                    if ((gotTurAdiNamesFail))
                    {
                        olmayanlar += " 'TurAdi' ";
                    }
                    if ((gotKayitGirenKisiNamesFail))
                    {
                        olmayanlar += " 'KaydiGirenKisi' ";
                    }
                    labelMessage.Text = "Tablodaki " + olmayanlar + "verileri combocoxa aktarılamadı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    gotmahalleNamesFail = false; gotCaddeSokakParkNamesFail = false; gotTurAdiNamesFail = false; gotKayitGirenKisiNamesFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion

            #region Datagride Tablo yüklenememişse
            else if (loadedTableFail)
            {
                if (timerCount != 0)
                {
                    labelMessage2.Visible = true;
                    labelMessage2.Text = "Tablo yüklenemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage2.Text = "";
                    labelMessage2.Visible = false;
                    timerCount = 3;
                    loadedTableFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion

            #region Toplanamayan kolon varsa
            else if (sumColumnsFail)
            {
                if (timerCount != 0)
                {
                    labelMessage2.Visible = true;
                    labelMessage2.Text = "" + toplanamayanKolonlar + " verileri toplanamadı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage2.Text = "";
                    labelMessage2.Visible = false;
                    timerCount = 3;
                    sumColumnsFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion

            #region Rapor yüklendiyse
            if (loadedRapor)
            {
                if (timerCount != 0)
                {
                    labelMessage2.Visible = true;
                    labelMessage2.Text = finished.Milliseconds.ToString() + " mili saniyede rapor excele aktarıldı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage2.Text = "";
                    labelMessage2.Visible = false;
                    timerCount = 3;
                    loadedRapor = false;
                    timer1.Enabled = false;
                }
            }
            #endregion

            #region Rapor Yüklenemediyse
            else if (loadedRaporFail)
            {
                if (timerCount != 0)
                {
                    labelMessage2.Visible = true;
                    labelMessage2.Text = "Rapor aktarılırken bi hata oluştu..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage2.Text = "";
                    labelMessage2.Visible = false;
                    timerCount = 3;
                    loadedRaporFail = true;
                    timer1.Enabled = false;
                }
            }
            #endregion

        }
        #endregion 6. ___________

    }
}
