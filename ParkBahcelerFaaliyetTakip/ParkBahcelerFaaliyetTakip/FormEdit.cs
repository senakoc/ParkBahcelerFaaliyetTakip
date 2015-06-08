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
    public partial class FormEdit : Form
    {
        #region GlobalDEğişkenler 
        //sorgu
        private List<string> computedColumn = null;
        private int sameRowNumber = 0;

        //Satırnumaları
        private bool prevClick = false;
        private bool nextClick = false;
        private int satirNumarasi = 1;

        //kontroller
        private Label label = null;
        private ComboBox combo =null;
        private DateTimePicker time = null;
        private TextBox text = null;

        //timer
        private int timerCount = 3;
        private bool loadingFail = false;//Form controls yükleme başarısızmı
        private bool isntDigit = false;//rakam değilmi
        private bool emptyValue = false;//boşdeğer girilmişmi
        private bool updatingSuccessful = false;//güncelleme başarılımı
        private bool updatingUnsuccessful = false;//güncelleme başarısızmı
        private bool readDataFromTableFail = false;//kayıt verilerini okuma başarısızmı
        private bool entryNotChanged = false;
        private bool eror = false;

        //form
        public FormMain main;
        #endregion        

        #region 1. FormEdit
        public FormEdit()
        {
            InitializeComponent();
        }
        #endregion

        #region 2. FormEdit Load
        private void FormEdit_Load(object sender, EventArgs e)
        {
            panelColumnName.Controls.Clear();
            panelValues.Controls.Clear();
            TextBoxSatirNo.Clear();

            sameRowNumber = 0;
            prevClick = false;
            nextClick = false;

            ButtonKaydet.Enabled = false;//bi değişiklik olduğu zaman true
            satirNumarasi = 1;// textbox otomatik değeri


            computedColumns();//otomatik hesaplanan kolon isimler

            if (!loadColumnsNames()) //Kolon isimlerinin yüklenememesi
            {
                loadingFail = true;
                timer1.Enabled = true;
            }
        }
        #endregion

        #region 3. FormEdit Load Fonksiyonları
   
        #region 3.1. Hesaplanan kolon isimleri
        private List<string> computedColumns()
        {
            computedColumn = new List<string>();
            computedColumn = main.getReaderList("SELECT name FROM sys.computed_columns WHERE object_id = OBJECT_ID('[" + main.databaseName + "].[dbo].[" + main.tableName + "]')");
            return computedColumn;
        }
        #endregion 3.1. END

        #region 3.2. Form kontrollerinin yüklenmesi

        #region 3.2.1. Kontorllerin yüklenmesi
        private bool loadColumnsNames()
        {
            #region TRY
            try
            {
                bool var = false;
                for (int i = 1; i < main.dataGridView1.ColumnCount - 1; i++)
                {
                    foreach (string item in computedColumn)
                    {
                        if (main.dataGridView1.Columns[i].HeaderText == item)
                        {
                            var = true;
                        }
                    }
                    #region Label isimleri
                    label = new Label();
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(30, ((i-1) * 60) + 40);
                    label.Text = main.dataGridView1.Columns[i].HeaderText.ToString();
                    if (var || i==1)
                    {
                        label.Enabled = false;
                    }
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
                                combo.Location = new System.Drawing.Point(28, (((i - 1)) * 60) + 40);
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
                                if (var)
                                {
                                    combo.Enabled = false;
                                }

                                combo.KeyPress += new KeyPressEventHandler(harfGirisi);
                                combo.SelectionChangeCommitted += new EventHandler(YonTuslarıİleDegisim);

                                panelValues.Controls.Add(combo);
                                break;
                            }
                        #endregion

                        #region Caddesokakpark combo
                        case "CaddeSokakPark":
                            {
                                combo = new ComboBox();

                                combo.FormattingEnabled = true;
                                combo.Location = new System.Drawing.Point(28, (((i - 1)) * 60) + 40);
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
                                if (var)
                                {
                                    combo.Enabled = false;
                                }

                                combo.KeyPress += new KeyPressEventHandler(harfGirisi);
                                combo.SelectionChangeCommitted += new EventHandler(YonTuslarıİleDegisim);

                                panelValues.Controls.Add(combo);
                                break;
                            }
                        #endregion

                        #region Turadi combobox
                        case "TurAdi":
                            {
                                combo = new ComboBox();
                                combo.FormattingEnabled = true;
                                combo.Location = new System.Drawing.Point(28, (((i - 1)) * 60) + 40);
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
                                if (var)
                                {
                                    combo.Enabled = false;
                                }
                                combo.KeyPress += new KeyPressEventHandler(harfGirisi);
                                combo.SelectionChangeCommitted += new EventHandler(YonTuslarıİleDegisim);
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
                                    text.Location = new System.Drawing.Point(30, (((i - 1)) * 60) + 40);
                                    text.Size = new System.Drawing.Size(457, 24);
                                    text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                                    if (main.dataGridView1.Columns[i].ValueType == typeof(System.Int32))
                                    {
                                        text.KeyPress += new KeyPressEventHandler(RakamKontrolu);
                                    }
                                    if (var || i==1)
                                    {
                                        text.Enabled = false;
                                    }
                                    panelValues.Controls.Add(text);
                                    text.KeyPress += new KeyPressEventHandler(harfGirisi);
                                }
                                else if (main.dataGridView1.Columns[i].ValueType == typeof(System.DateTime))
                                {
                                    time = new DateTimePicker();
                                    time.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                    time.CustomFormat = "dd.MM.yyyy";
                                    time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                                    time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                                    time.Location = new System.Drawing.Point(28, (((i - 1)) * 60) + 40);
                                    time.Value = DateTime.Today;
                                    if (var)
                                    {
                                        time.Enabled = false;
                                    }
                                    time.KeyPress += new KeyPressEventHandler(harfGirisi);
                                    time.MouseCaptureChanged += new EventHandler(timeClick);
                                    panelValues.Controls.Add(time);
                                }
                                break;
                            }
                        #endregion
                    }
                    #endregion                    
                        
                    var = false;
                }

                return true;
            }
            #endregion

            #region CATCH
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            #endregion
        }
        #endregion 3.2.1. END

        #region 3.2.2. controls event
      
        #region 3.2.2.1. Güncelle butonu enable eventleri
        private void timeClick(object sender, EventArgs e)
        {
            if (!ButtonKaydet.Enabled)
            {
                ButtonKaydet.Enabled = true;
            }
        }

        private void tiklama(object sender, EventArgs e)
        {
            if (!ButtonKaydet.Enabled)
            {
                ButtonKaydet.Enabled = true;
            }
        }

        private void YonTuslarıİleDegisim(object sender, EventArgs e)
        {
            if (!ButtonKaydet.Enabled)
            {
                ButtonKaydet.Enabled = true;
            }            
        }

        private void harfGirisi(object sender, KeyPressEventArgs e)
        {
            if (!ButtonKaydet.Enabled)
            {
                ButtonKaydet.Enabled = true;
            }
        }
        #endregion 3.2.2.1. END

        #region 3.2.2.2. textbox rakam giriş kontrolü
        private void RakamKontrolu(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                isntDigit = true;
                timer1.Enabled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                   isntDigit = false; 
            }
        }
        #endregion 3.2.2.2. END

        #endregion 3.2.2. END

        #endregion 3.2. END

        #endregion 3.END

        #region 4. satirlar arasi gezinme
     
        #region 4.1. İleri butonu
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            nextClick = true;
            satirlarArasıIGezinme();
            nextClick = false;
        }
        #endregion 4.1. END

        #region 4.2. Geri butonu
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            prevClick = true;
            satirlarArasıIGezinme();
            prevClick = false;            
        }
        #endregion 4.2. END

        #region 4.3. (ileri\geri) satirNumarasinin ayarlanması
        private void satirlarArasıIGezinme()
        {
            #region satir numarası boş deilse
            if (TextBoxSatirNo.Text.Trim() == "") //boşsa sistemden ilerle
            {
                TextBoxSatirNo.Text = satirNumarasi.ToString();
            }
            #endregion

            #region satır numarası boş deilse
            else if (TextBoxSatirNo.Text.Trim() != "") // demekki bi satır numarası girmiş ordan devam et
            {
                if (!isntDigit)
                {
                    satirNumarasi = Convert.ToInt32(TextBoxSatirNo.Text);
                    if (prevClick)//GERİ gitmek isterse
                    {
                        if (satirNumarasi != 0)// 0 deilse azaltılabilir
                        {
                            satirNumarasi--;
                        }
                    }
                    if (nextClick)//İLERİ gitmek istese
                    {
                        if (satirNumarasi != main.dataGridView1.RowCount + 1)// son kayıda ulaşmamışsa
                        {
                            satirNumarasi++;
                        }
                    }

                    if (satirNumarasi == main.dataGridView1.RowCount + 1) //sonkayıda ulaşmışsa ilk kayıttan devam
                    {
                        satirNumarasi = 1;
                    }
                    else if (satirNumarasi == 0)// 0 olmuşsa geri gitmek için son kayıttan devam
                    {
                        satirNumarasi = main.dataGridView1.RowCount;
                    }
                    else if (satirNumarasi > main.dataGridView1.RowCount)//kullnıcı son kayıttan büyük değer girerse son kayıta otomatik at
                    {
                        satirNumarasi = main.dataGridView1.RowCount;
                    }

                    TextBoxSatirNo.Text = satirNumarasi.ToString();
                }
            }
            #endregion
        }
        #endregion

        #endregion 4. END 

        #region 5. Satir numarası textbox events

        #region 5.1. Satir Numarası textboxında textin değişmesi ile verilerin getirilmesi
        private void SatirNoTextBox_Changed(object sender, EventArgs e)
        {
            if (!(isntDigit) && TextBoxSatirNo.Text != "")
            {
                int satırNo = Convert.ToInt32(TextBoxSatirNo.Text);
                if (satırNo > main.dataGridView1.RowCount)// olmayan satırı girmişse
                {
                    ButtonKaydet.Enabled = false; 
                    TextBoxSatirNo.BackColor = Color.Red;
                }
                else
                {
                    TextBoxSatirNo.BackColor = Color.White;
                    if (!kayitVerileri(satırNo))//veriler getirilememişse
                    {
                        readDataFromTableFail = true;
                        timer1.Enabled = true;
                    }
                }
            }

        }
        #endregion 5.1. END

        #region 5.2. Tablodaki satir değerlerinin kontrollere aktarılması
        private bool kayitVerileri(int satırNo)
        {
            try
            {
                for (int i = 1; i < main.dataGridView1.ColumnCount-1; i++)
                {
                    panelValues.Controls[i - 1].Text = main.dataGridView1[i, (satırNo - 1)].Value.ToString();        
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        #endregion 5.2. END

        #endregion 5. END

        #region 6. Güncelle butonu için fonksiyonu
        private string getValues(int satirNo) 
        {
            string sorguSET = "";
            string columnName = "";
            string value = "";
            try
            {
                #region Bi değişiklik yapmışmı
                bool change = false;
                string text = "";
                for (int j = 1; j < main.dataGridView1.ColumnCount - 1; j++)
                {
                    if (panelColumnName.Controls[j-1].Enabled)
                    {
                        if (main.dataGridView1[panelColumnName.Controls[j - 1].Text, satirNo].ValueType == typeof(System.DateTime))
                        {
                            DateTime a = (DateTime)main.dataGridView1[panelColumnName.Controls[j - 1].Text, satirNo].Value;
                            text = a.ToString("d.MM.yyyy");
                        }
                        else
                        {
                            text = main.dataGridView1[panelColumnName.Controls[j - 1].Text, satirNo].Value.ToString();
                        }
                        if(text != panelValues.Controls[j-1].Text)
                        {
                            change = true;
                            break;
                        }
                    }
                }
                #endregion

                #region olan bi kaydın aynısınımı yapıo
                sameRowNumber = 0;
                for (int i = 0; i < main.dataGridView1.RowCount; i++) // satırları dolaşcak
                {
                    if (i != satirNo)//aynı kayıda bakmasın
                    {
                        string satirBilgileri = "";
                        string panelBilgileri = "";
                        sameRowNumber = i + 1;
                        for (int j = 1; j < main.dataGridView1.ColumnCount - 1; j++)//kolonları dolancak
                        {
                            if (main.dataGridView1[j, i].ValueType == typeof(System.DateTime))
                            {
                                DateTime a = (DateTime)main.dataGridView1[j, i].Value;
                                text = a.ToString("d.MM.yyyy");
                            }
                            else
                            {
                                text = main.dataGridView1[j, i].Value.ToString();
                            }
                            if (panelValues.Controls[j - 1].Enabled)
                            {
                                satirBilgileri += " " + text + " ";
                                panelBilgileri += " " + panelValues.Controls[j - 1].Text + " ";
                            }
                        }
                        if (satirBilgileri == panelBilgileri)
                        {
                            break;
                        }
                        else
                            sameRowNumber = 0;
                    }
                }
                #endregion

                #region değişiklik yapılmışsa
                if (change)
                {
                    for (int i = 1; i < panelValues.Controls.Count; i++) //tüm kontrolleri dolaşıcak kayıt no hariç
                    {
                        if (panelValues.Controls[i].Enabled)
                        {
                            columnName = " [" + panelColumnName.Controls[i].Text + "] ";
                            if (panelValues.Controls[i].Text.Trim() != "")
                            {
                                if (main.dataGridView1.Columns[i + 1].ValueType == typeof(String))
                                {
                                    value = " '" + panelValues.Controls[i].Text.Trim() + "' ";
                                }
                                else if (main.dataGridView1.Columns[i + 1].ValueType == typeof(Int32))
                                {
                                    value = " " + panelValues.Controls[i].Text.Trim() + " ";
                                }
                                else if (panelValues.Controls[i] is DateTimePicker)
                                {
                                    DateTime a = ((DateTimePicker)panelValues.Controls[i]).Value;
                                    string time = a.ToString("MM.d.yyyy");//bu çeviri sqle kayıt için gerekli
                                    value = " '" + time + "' ";
                                }
                                sorguSET += "" + columnName + " = " + value + ", ";
                            }
                            else // boş kayıt girilmiş
                            {
                                return "b"; 
                            }
                        }
                    }
                    string sorgum = "UPDATE [" + main.databaseName + "].[dbo].[" + main.tableName + "] SET " + sorguSET.Substring(0,sorguSET.Length-2) + " WHERE [KayitNo] = " + main.dataGridView1[1, satirNo].Value + "";
                    return sorgum;
                }
                else
                {
                    return "a";//aynı kaydı eklio
                }
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "!";
            }
        }
        #endregion 6. END

        #region 7. Güncelle buton
        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            bool guncelle = true;
            int satirNo = Convert.ToInt32(TextBoxSatirNo.Text);
            satirNo--;
            string sorgum = getValues(satirNo);

            if (sorgum == "a")// değişiklik olmadı
            {
                entryNotChanged = true;
                timer1.Enabled = true;
                guncelle = false;
            }

            else if (sorgum == "b")// boş kayıt
            {
                emptyValue = true;
                timer1.Enabled = true;
                guncelle = false;
            }

            else if (sorgum == "!")
            {
                guncelle = false;
            }

            #region Güncelleme yapılcak
            if (guncelle)
            {
                bool yes = true;
                if (sameRowNumber != 0)
                {
                    DialogResult sonuc = MessageBox.Show("Güncellemek istediğiniz kayıt " + sameRowNumber + ". satırda zaten mevcut. \n\t Genede eklensinmi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        yes = true;
                    }
                    else
                    {
                        yes = false;
                    }
                }
                if (yes)
                {
                    int affectedRow = main.getExectuQuery(sorgum);
                    if (affectedRow != 0)
                    {
                        main.loadTable();
                        updatingSuccessful = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        updatingUnsuccessful = true;
                        timer1.Enabled = true;
                    }
                }
            }
            #endregion
        }
        #endregion 7. END   

        #region 8. Cikis butonu
        private void cikisButon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion 8. END

        #region 9. Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 1. Form controlleri yüklenmemişse
            if (loadingFail)
            {
                if (timerCount < 4)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Form tablo verileriyle oluşturlamadı..."+timerCount;
                    timerCount++;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 0;
                    loadingFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1.END
            
            #region 2. Rakam girmezse
            else if (isntDigit)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Yalnızca rakam girebilirsiniz..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    isntDigit = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 2. END

            #region 3. Veriler okunamadıysa
            else if (readDataFromTableFail)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = TextBoxSatirNo.Text+". satırdaki veriler alınamadı..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    readDataFromTableFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 3. END

            #region 4. Güncelleme başarısızsa
            else if (updatingUnsuccessful)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Kayıt güncelleme başarısız ..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    updatingUnsuccessful = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 4. END

            #region 5. Güncelleme başarılıysa
            else if (updatingSuccessful)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Kayıt güncelleme başarılı ..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    updatingSuccessful = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 5.END    

            #region 6. bi değişiklik olmammışsa
            else if (entryNotChanged)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Herhangi bir değişiklik yapmadınız..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    entryNotChanged = false;
                    timerCount = 3;
                    timer1.Enabled = false;
                }
            }
            #endregion 6. END

            #region 7. boş değer girilmişse
            else if (emptyValue)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Boş değer giremezsiniz..." + timerCount;
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
            #endregion 7. END

            #region 8. bi hata oluşmuşsa
            else if (eror)
            {
                MessageBox.Show("eror");
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Bir hata oluştu..." + timerCount;
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
            #endregion 8. END

            
        }
        #endregion 9. END
    }
}
