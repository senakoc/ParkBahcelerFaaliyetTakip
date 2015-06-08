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
    public partial class FormAdd : Form
    {
        #region Global değişkenelr
        //sorgu için
        private List<string> computedColumn = null;
        private bool sameRow = false;
        private int satirNo;

        //controls
        private Label label = null;
        private ComboBox combo = null;
        private TextBox text = null;
        private DateTimePicker time = null;

        //timer
        private int timerCount = 3;
        private bool loadingFail = false;//Form controls yükleme başarısızmı
        private bool emptyValue = false;//boşdeğer girilmişmi
        private bool addingSuccessful = false;//ekleme başarılımı
        private bool addingUnsuccessful = false;//ekleme başarısızmı
        private bool isntDigit = false;//rakam değilmi
        private bool eror = false;

        // Form
        public FormMain main;
        
        #endregion Global END

        #region 1. FormAdd
        public FormAdd()
        {
            InitializeComponent();

        }
        #endregion

        #region 2. FormAdd Load
        private void FormAdd_Load(object sender, EventArgs e)
        {
            //bellekteki halleri temizleniyor
            panelColumnName.Controls.Clear();
            panelValues.Controls.Clear();
            sameRow = false;
            //hesaplanan kolon varsa alınıyor
            computedColumns();
            
            if (!formControlsLoad())
            {
                loadingFail = true;
                timer1.Enabled = true;
            }
        }
        #endregion 2. END

        #region 3. Form Load fonksiyonlar
       
        #region 3.1 Hesaplanan kolon isimleri
        private List<string> computedColumns()
        {
            computedColumn = new List<string>();
            computedColumn = main.getReaderList("SELECT name FROM sys.computed_columns WHERE object_id = OBJECT_ID('[" + main.databaseName + "].[dbo].[" + main.tableName + "]')");
            return computedColumn;
        }
        #endregion 3.1 END

        #region 3.2. Form kontrollerinin yüklenmesi

        #region 3.2.1 Kontrollerin yüklenmesi
        private bool formControlsLoad()
        {
            #region TRY
            try
            {
                bool var = false;
                int y;
                y = -1;
                for (int i = 2; i < main.dataGridView1.ColumnCount - 1; i++)// kolonları geziyo
                {
                    foreach (string item in computedColumn)
                    {
                        if (main.dataGridView1.Columns[i].HeaderText == item)// eğer hesaplanan kolonlara dahilse
                        {
                            var = true; 
                        }
                    }
                    if (!var)
                    {
                        y++;
                        #region Label isimleri
                        label = new Label();
                        label.AutoSize = true;
                        label.Location = new System.Drawing.Point(30, (y * 60) + 40);
                        label.Text = main.dataGridView1.Columns[i].HeaderText.ToString();

                        panelColumnName.Controls.Add(label);
                        #endregion 

                        #region değerlerin girilceği kontroller
                        switch (main.dataGridView1.Columns[i].HeaderText)
                        {
                            #region mahalle combobox
                            case "Mahalle":
                                {
                                    combo = new ComboBox();
                                    combo.FormattingEnabled = true;
                                    combo.Location = new System.Drawing.Point(28, ((y) * 60) + 40);
                                    combo.Size = new System.Drawing.Size(457, 24);
                                    combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                    combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                                    combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                                    combo.BackColor = System.Drawing.SystemColors.Window;
                                    combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                    combo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                    combo.Items.AddRange(new object[] {"AKINCILAR MAHALLESİ", "GENÇOSMAN MAHALLESİ", "GÜNEŞTEPE MAHALLESİ", "GÜVEN MAHALLLESİ", "HAZNEDAR MAHALLESİ", 
                                                                    "M.NESİH ÖZMEN MAHALLESİ","MAREŞAL ÇAKMAK MAHALLESİ","MERKEZ MAHALLESİ","MERKEZ MAHALLESİ","SANAYİ MAHALLESİ","TOZKOPARAN MAHALLESİ"});

                                    combo.Sorted = true;
                                    panelValues.Controls.Add(combo);
                                    break;
                                }
                            #endregion
                          
                            #region Caddesokakpark combo
                            case "CaddeSokakPark":
                                {
                                    combo = new ComboBox();
                                    combo = new ComboBox();
                                    combo.FormattingEnabled = true;
                                    combo.Location = new System.Drawing.Point(28, ((y) * 60) + 40);
                                    combo.Size = new System.Drawing.Size(457, 24);
                                    combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                    combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                                    combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                                    combo.BackColor = System.Drawing.SystemColors.Window;
                                    combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                    combo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                    combo.Items.AddRange(new object[] { "POSTA CADDESİ", "SOĞANLI CADDESİ", "MEVLEVİHANE OTOPARKI", "KIŞLA SOKAK", "CEM SULTAN SOKAK", "MEVLEVİHANE OTOPARKI", "YAVUZ SELİM CADDESİ", "GEÇİT SOKAK", "RAZAKİ SOKAK", "KIVIRCIK SOKAK",
                                "SOĞANLI CADDESİ", "KINALI CADDESİ", "SPOR PARKI","ESKİ KAYMAKAMLIK ÖNÜ", "CEVİZLİK PARKI" ,"MIZRAK SOKAK", "BİRCAN ERESİN CAMİİ", "ESKİ LONDRA ASFALTI", "ABDİ İPEKÇİ CADDESİ"});

                                    combo.Sorted = true;
                                    panelValues.Controls.Add(combo);
                                    break;
                                }
                            #endregion

                            #region Turadi combobox
                            case "TurAdi":
                                {
                                    combo = new ComboBox();
                                    combo = new ComboBox();
                                    combo.FormattingEnabled = true;
                                    combo.Location = new System.Drawing.Point(28, ((y) * 60) + 40);
                                    combo.Size = new System.Drawing.Size(457, 24);
                                    combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                    combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                                    combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
                                    combo.BackColor = System.Drawing.SystemColors.Window;
                                    combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                    combo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                    combo.Items.AddRange(new object[] {"DEFNE", "MANOLYA", "LİGUSTRUM","ALACALI", "LİGUSTRUM", "TETTO", "İLEX", "ALEV", 
                                    "LEYLANDİ", "OYA", "HATMİ", "SEDİR", "SPİRAL LEYLANDİ", "SÜS ERiĞİ", "SIĞLA", "ZAKKUM", "ERGUVAN", "ZEYTİN", 
                                    "BONZAİ", "CYCAS", "SEDİR", "2 TOP LEYLANDİ" , "3 TOP LEYLANDİ", "3 TOP MAZI" ,"AKASYA"});

                                    combo.Sorted = true;
                                    panelValues.Controls.Add(combo);
                                    break;
                                }
                            #endregion

                            #region Default
                            default:
                                {
                                    if (main.dataGridView1.Columns[i].ValueType != typeof(System.DateTime))
                                    {
                                        text = new TextBox();
                                        text.Location = new System.Drawing.Point(30, ((y) * 60) + 40);
                                        text.Size = new System.Drawing.Size(457, 24);
                                        text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                        if (main.dataGridView1.Columns[i].ValueType == typeof(System.Int32))
                                        {
                                            text.KeyPress += new KeyPressEventHandler(RakamKontrolu);
                                        }
                                        if (main.dataGridView1.Columns[i].HeaderText == "KaydiGirenKisi")
                                        {
                                            text.Text = main.kayitGiren;
                                        }
                                        panelValues.Controls.Add(text);
                                    }
                                    else if (main.dataGridView1.Columns[i].ValueType == typeof(System.DateTime))
                                    {
                                        time = new DateTimePicker();
                                        time.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                        time.CustomFormat = "dd.MM.yyyy";
                                        time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                        time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                                        time.Location = new System.Drawing.Point(28, ((y) * 60) + 40);

                                        panelValues.Controls.Add(time);
                                    }
                                    break;
                                }
                            #endregion
                        }
                        #endregion
                    }
                    var = false;
                }
                return true;
            }
            #endregion

            #region CATCH
            catch (Exception)
            {

                return false;
            }
            #endregion
        }
        #endregion 3.2.1 END

        #region 3.2.2 Controls eventleri
        private void RakamKontrolu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                isntDigit = true;
                timer1.Enabled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                isntDigit = false;
            }
        }
        #endregion

        #endregion 3.2. END
        
        #endregion 3. END

        #region 4. Kaydet butonu fonksiyonları
       
        #region 4.1. Form verilerinin okunması
        private string getValues()
        {
            try
            {
                string sorguValues = "";
                string sorguColumnNames = "";
              
                #region Değerlerin alınması
                for (int i = 0; i < panelValues.Controls.Count; i++) // tüm kontrolleri dolaşcak
                {
                    #region Kolon isimlerinin sorgu için alınması
                    sorguColumnNames += "[" + panelColumnName.Controls[i].Text.Trim() + "], ";
                    #endregion

                    #region Girilen değerlerin alınması
                    if (panelValues.Controls[i].Text.Trim() != "") // text girilmişse texleri alcak
                    {
                        if (panelValues.Controls[i] is DateTimePicker)
                        {
                            DateTime a = ((DateTimePicker)panelValues.Controls[i]).Value;
                            string time = a.ToString("MM.d.yyyy");//bu çeviri sqle kayıt için gerekli
                            sorguValues += "'" + time + "', ";
                        }
                        else
                        {
                            sorguValues += "'" + panelValues.Controls[i].Text.Trim() + "', ";
                        }
                    }
                    else//text girilmemişse text alma işi bitcek 
                    {
                        sorguValues = "";
                        return "b"; // fonksiyondan çıkılcak
                    }
                    #endregion
                }
                #endregion

                #region Tabloda eklenmek istenen kayıt varmı
                sameRow = false;
                satirNo = 0;
                for (int r = 0; r < main.dataGridView1.RowCount; r++) // satırları dolaşcak
                {
                    string satirBilgileri = "";
                    satirNo = r + 1;
                    foreach (Control k in panelColumnName.Controls)
                    {
                        if (main.dataGridView1[k.Text, r].ValueType == typeof(System.DateTime))
                        {
                            DateTime a = (DateTime)main.dataGridView1[k.Text, r].Value;
                            satirBilgileri += "'" + a.ToString("d.MM.yyyy") + "', ";
                        }
                        else
                        {
                             satirBilgileri += "'" + main.dataGridView1[k.Text, r].Value.ToString() + "', ";
                        }
                    }
                    if (satirBilgileri == sorguValues)
                    {
                        sameRow = true;
                        break;
                    }
                }
                #endregion

                string sorgum = "INSERT INTO [" + main.databaseName + "].[dbo].[" + main.tableName + "] (" + sorguColumnNames.Substring(0, sorguColumnNames.Length-2) + ") VALUES (" + sorguValues.Substring(0,sorguValues.Length-2)+ ") ";
                return sorgum; // textler gönderilcek
            }
            catch (Exception e)
            {
                MessageBox.Show("Oluşan hata\n"+e.Message);
                eror = true;
                timer1.Enabled = true;
                return "!";
            }
        }
        #endregion 4.1. END

        #region 4.2. Kontrol textlerinin temizlenmesi
        private void clearTexts()
        {
            foreach (Control item in panelValues.Controls)
            {
                if (!(item is Label))
                {
                    if (item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Value = DateTime.Today;
                    }
                    else
                    {
                        item.Text = "";
                    }
                }
            }
        }
        #endregion 4.2. END

        #endregion 4. END
       
        #region 5. Kaydet butonu
        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            string sorgum = getValues();
            
            #region Boş veri girilmiş
            if (sorgum == "b") 
            {
                emptyValue = true;
                timer1.Enabled = true;
            }
            #endregion

            #region Boşluk yoksa ve bi hata oluşmamışsa kayıt işlemine geçilcek
            else if ((sorgum != "*") || (sorgum != "!"))
            {
                bool kaydet = true;
                
                #region aynı kayıt varsa
                if (sameRow)
                {
                    DialogResult sonuc = MessageBox.Show("Eklenmek istediğiniz kayıt "+satirNo+". satırda zaten mevcut. \n\t Genede eklensinmi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        kaydet = true;
                    }
                    else
                    {
                        kaydet = false;
                    }
                }
                #endregion

                #region kaydet
                if (kaydet)
                {
                    int resultExe = main.getExectuQuery(sorgum);
                    if (resultExe != 0) // etkilenen satır sayısı 0 deilse demk kayıt olmuş
                    {
                        addingSuccessful = true;
                        timer1.Enabled = true;
                        main.loadTable();
                        clearTexts();
                    }
                    else if (resultExe == 0) // kayıt olmamış
                    {
                        addingUnsuccessful = true;
                        timer1.Enabled = true;
                    }
                }
                #endregion
            }
            #endregion
        }
        #endregion 5. END

        #region 6. Çıkış butonu
        private void cikisButon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion 6.END

        #region 7. Tİmer
        private void timer1_Tick(object sender, EventArgs e)
        {            
            #region 1. Form controlleri yüklenmemişse
            if (loadingFail)// true değilse
            {
                MessageBox.Show("form load");
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Form tablo verileriyle oluşturlamadı..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    loadingFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1. END

            #region 2. Boş alan bırakılmışsa
            else if (emptyValue)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Boş alan bırakmayınız..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    emptyValue = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 2.END

            #region 3. Kayıt eklenememişse
            else if (addingUnsuccessful)//false değilse
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Kayıt "+main.tableName+" tablosuna eklenemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    addingUnsuccessful = false;
                    timerCount = 3;
                    timer1.Enabled = false;                    
                }
            }
            #endregion 3. END

            #region 4. Kayıt eklenmişse
            else if (addingSuccessful)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Kayıt " + main.tableName + " tablosuna eklendi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    addingSuccessful = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 4.END

            #region 5. Rakam girmezse
            else if (isntDigit)// true ise 
            {
                if (timerCount!= 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Bu kolona yalnızca rakamsal değerler kayıt edilebilir..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    isntDigit = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 5.END

            #region 6. bi hata oluşmuşsa
            else if (eror)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Bir hata oluştu..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    eror = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 6. END
        }
        #endregion 7. END
    }
}
