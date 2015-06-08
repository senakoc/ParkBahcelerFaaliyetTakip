namespace ParkBahcelerFaaliyetTakip
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAyarlar = new System.Windows.Forms.TabPage();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxFiltreler = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.labelAygn = new System.Windows.Forms.Label();
            this.labelAygün = new System.Windows.Forms.Label();
            this.comboBoxKayıtGirenler = new System.Windows.Forms.ComboBox();
            this.comboBoxTurAdi = new System.Windows.Forms.ComboBox();
            this.comboBoxCaddeSokakPark = new System.Windows.Forms.ComboBox();
            this.comboBoxMahalle = new System.Windows.Forms.ComboBox();
            this.labelBitisTariihi = new System.Windows.Forms.Label();
            this.labelBaslangicTarihi = new System.Windows.Forms.Label();
            this.labelSorumlu = new System.Windows.Forms.Label();
            this.labelTurAdi = new System.Windows.Forms.Label();
            this.labelCaddeSokakPark = new System.Windows.Forms.Label();
            this.labelMahalle = new System.Windows.Forms.Label();
            this.groupBoxKolonlar = new System.Windows.Forms.GroupBox();
            this.tabPageRapor = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporuExceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerRapor = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAyarlar.SuspendLayout();
            this.groupBoxFiltreler.SuspendLayout();
            this.tabPageRapor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRapor)).BeginInit();
            this.splitContainerRapor.Panel1.SuspendLayout();
            this.splitContainerRapor.Panel2.SuspendLayout();
            this.splitContainerRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAyarlar);
            this.tabControl1.Controls.Add(this.tabPageRapor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 717);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageAyarlar
            // 
            this.tabPageAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAyarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAyarlar.Controls.Add(this.labelMessage);
            this.tabPageAyarlar.Controls.Add(this.groupBoxFiltreler);
            this.tabPageAyarlar.Controls.Add(this.groupBoxKolonlar);
            this.tabPageAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabPageAyarlar.Location = new System.Drawing.Point(4, 25);
            this.tabPageAyarlar.Name = "tabPageAyarlar";
            this.tabPageAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAyarlar.Size = new System.Drawing.Size(1236, 688);
            this.tabPageAyarlar.TabIndex = 0;
            this.tabPageAyarlar.Text = "Rapor Ayarları";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.White;
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(40, 646);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(2, 26);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Visible = false;
            // 
            // groupBoxFiltreler
            // 
            this.groupBoxFiltreler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltreler.AutoSize = true;
            this.groupBoxFiltreler.Controls.Add(this.buttonClear);
            this.groupBoxFiltreler.Controls.Add(this.label1);
            this.groupBoxFiltreler.Controls.Add(this.checkedListBox1);
            this.groupBoxFiltreler.Controls.Add(this.dateTimePickerBitis);
            this.groupBoxFiltreler.Controls.Add(this.dateTimePickerBaslangıc);
            this.groupBoxFiltreler.Controls.Add(this.labelAygn);
            this.groupBoxFiltreler.Controls.Add(this.labelAygün);
            this.groupBoxFiltreler.Controls.Add(this.comboBoxKayıtGirenler);
            this.groupBoxFiltreler.Controls.Add(this.comboBoxTurAdi);
            this.groupBoxFiltreler.Controls.Add(this.comboBoxCaddeSokakPark);
            this.groupBoxFiltreler.Controls.Add(this.comboBoxMahalle);
            this.groupBoxFiltreler.Controls.Add(this.labelBitisTariihi);
            this.groupBoxFiltreler.Controls.Add(this.labelBaslangicTarihi);
            this.groupBoxFiltreler.Controls.Add(this.labelSorumlu);
            this.groupBoxFiltreler.Controls.Add(this.labelTurAdi);
            this.groupBoxFiltreler.Controls.Add(this.labelCaddeSokakPark);
            this.groupBoxFiltreler.Controls.Add(this.labelMahalle);
            this.groupBoxFiltreler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFiltreler.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFiltreler.Location = new System.Drawing.Point(381, 25);
            this.groupBoxFiltreler.Name = "groupBoxFiltreler";
            this.groupBoxFiltreler.Size = new System.Drawing.Size(822, 651);
            this.groupBoxFiltreler.TabIndex = 1;
            this.groupBoxFiltreler.TabStop = false;
            this.groupBoxFiltreler.Text = "Filtreler";
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.Location = new System.Drawing.Point(591, 18);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(144, 34);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Filtreleri Temizle";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ControlsText_Clear);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toplamı alınabilir kolonlar";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(261, 413);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(473, 186);
            this.checkedListBox1.TabIndex = 14;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBitis.CustomFormat = "MM.d.yyyy";
            this.dateTimePickerBitis.Enabled = false;
            this.dateTimePickerBitis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBitis.Location = new System.Drawing.Point(187, 347);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.ShowCheckBox = true;
            this.dateTimePickerBitis.Size = new System.Drawing.Size(455, 32);
            this.dateTimePickerBitis.TabIndex = 13;
            // 
            // dateTimePickerBaslangıc
            // 
            this.dateTimePickerBaslangıc.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslangıc.CustomFormat = "MM.d.yyyy";
            this.dateTimePickerBaslangıc.Enabled = false;
            this.dateTimePickerBaslangıc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslangıc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBaslangıc.Location = new System.Drawing.Point(187, 290);
            this.dateTimePickerBaslangıc.Name = "dateTimePickerBaslangıc";
            this.dateTimePickerBaslangıc.ShowCheckBox = true;
            this.dateTimePickerBaslangıc.Size = new System.Drawing.Size(455, 32);
            this.dateTimePickerBaslangıc.TabIndex = 12;
            // 
            // labelAygn
            // 
            this.labelAygn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAygn.AutoSize = true;
            this.labelAygn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAygn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAygn.Location = new System.Drawing.Point(648, 360);
            this.labelAygn.Name = "labelAygn";
            this.labelAygn.Size = new System.Drawing.Size(87, 19);
            this.labelAygn.TabIndex = 11;
            this.labelAygn.Text = "(Ay.Gün.Yıl)";
            // 
            // labelAygün
            // 
            this.labelAygün.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAygün.AutoSize = true;
            this.labelAygün.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelAygün.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAygün.Location = new System.Drawing.Point(648, 300);
            this.labelAygün.Name = "labelAygün";
            this.labelAygün.Size = new System.Drawing.Size(87, 19);
            this.labelAygün.TabIndex = 10;
            this.labelAygün.Text = "(Ay.Gün.Yıl)";
            // 
            // comboBoxKayıtGirenler
            // 
            this.comboBoxKayıtGirenler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxKayıtGirenler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKayıtGirenler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKayıtGirenler.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxKayıtGirenler.Enabled = false;
            this.comboBoxKayıtGirenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKayıtGirenler.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBoxKayıtGirenler.FormattingEnabled = true;
            this.comboBoxKayıtGirenler.Location = new System.Drawing.Point(187, 237);
            this.comboBoxKayıtGirenler.Name = "comboBoxKayıtGirenler";
            this.comboBoxKayıtGirenler.Size = new System.Drawing.Size(526, 28);
            this.comboBoxKayıtGirenler.TabIndex = 9;
            // 
            // comboBoxTurAdi
            // 
            this.comboBoxTurAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTurAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTurAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTurAdi.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTurAdi.Enabled = false;
            this.comboBoxTurAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTurAdi.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBoxTurAdi.FormattingEnabled = true;
            this.comboBoxTurAdi.Location = new System.Drawing.Point(187, 177);
            this.comboBoxTurAdi.Name = "comboBoxTurAdi";
            this.comboBoxTurAdi.Size = new System.Drawing.Size(526, 28);
            this.comboBoxTurAdi.TabIndex = 8;
            // 
            // comboBoxCaddeSokakPark
            // 
            this.comboBoxCaddeSokakPark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCaddeSokakPark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCaddeSokakPark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCaddeSokakPark.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCaddeSokakPark.Enabled = false;
            this.comboBoxCaddeSokakPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCaddeSokakPark.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBoxCaddeSokakPark.FormattingEnabled = true;
            this.comboBoxCaddeSokakPark.Location = new System.Drawing.Point(187, 117);
            this.comboBoxCaddeSokakPark.Name = "comboBoxCaddeSokakPark";
            this.comboBoxCaddeSokakPark.Size = new System.Drawing.Size(526, 28);
            this.comboBoxCaddeSokakPark.TabIndex = 7;
            // 
            // comboBoxMahalle
            // 
            this.comboBoxMahalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMahalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMahalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMahalle.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMahalle.Enabled = false;
            this.comboBoxMahalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMahalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMahalle.FormattingEnabled = true;
            this.comboBoxMahalle.Location = new System.Drawing.Point(187, 58);
            this.comboBoxMahalle.Name = "comboBoxMahalle";
            this.comboBoxMahalle.Size = new System.Drawing.Size(526, 28);
            this.comboBoxMahalle.TabIndex = 6;
            // 
            // labelBitisTariihi
            // 
            this.labelBitisTariihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBitisTariihi.AutoSize = true;
            this.labelBitisTariihi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelBitisTariihi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBitisTariihi.Location = new System.Drawing.Point(17, 360);
            this.labelBitisTariihi.Name = "labelBitisTariihi";
            this.labelBitisTariihi.Size = new System.Drawing.Size(94, 22);
            this.labelBitisTariihi.TabIndex = 5;
            this.labelBitisTariihi.Text = "Bitis Tarihi";
            // 
            // labelBaslangicTarihi
            // 
            this.labelBaslangicTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBaslangicTarihi.AutoSize = true;
            this.labelBaslangicTarihi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelBaslangicTarihi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslangicTarihi.Location = new System.Drawing.Point(17, 300);
            this.labelBaslangicTarihi.Name = "labelBaslangicTarihi";
            this.labelBaslangicTarihi.Size = new System.Drawing.Size(148, 22);
            this.labelBaslangicTarihi.TabIndex = 4;
            this.labelBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // labelSorumlu
            // 
            this.labelSorumlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSorumlu.AutoSize = true;
            this.labelSorumlu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelSorumlu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSorumlu.Location = new System.Drawing.Point(17, 240);
            this.labelSorumlu.Name = "labelSorumlu";
            this.labelSorumlu.Size = new System.Drawing.Size(131, 22);
            this.labelSorumlu.TabIndex = 3;
            this.labelSorumlu.Text = "Kayıt Girenler";
            // 
            // labelTurAdi
            // 
            this.labelTurAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTurAdi.AutoSize = true;
            this.labelTurAdi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelTurAdi.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTurAdi.Location = new System.Drawing.Point(17, 180);
            this.labelTurAdi.Name = "labelTurAdi";
            this.labelTurAdi.Size = new System.Drawing.Size(69, 22);
            this.labelTurAdi.TabIndex = 2;
            this.labelTurAdi.Text = "Tür Adi";
            // 
            // labelCaddeSokakPark
            // 
            this.labelCaddeSokakPark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaddeSokakPark.AutoSize = true;
            this.labelCaddeSokakPark.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCaddeSokakPark.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCaddeSokakPark.Location = new System.Drawing.Point(17, 120);
            this.labelCaddeSokakPark.Name = "labelCaddeSokakPark";
            this.labelCaddeSokakPark.Size = new System.Drawing.Size(170, 22);
            this.labelCaddeSokakPark.TabIndex = 1;
            this.labelCaddeSokakPark.Text = "CaddeSokakPark";
            // 
            // labelMahalle
            // 
            this.labelMahalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMahalle.AutoSize = true;
            this.labelMahalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelMahalle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMahalle.Location = new System.Drawing.Point(17, 60);
            this.labelMahalle.Name = "labelMahalle";
            this.labelMahalle.Size = new System.Drawing.Size(85, 22);
            this.labelMahalle.TabIndex = 0;
            this.labelMahalle.Text = "Mahalle";
            // 
            // groupBoxKolonlar
            // 
            this.groupBoxKolonlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxKolonlar.AutoSize = true;
            this.groupBoxKolonlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxKolonlar.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKolonlar.Location = new System.Drawing.Point(40, 25);
            this.groupBoxKolonlar.Name = "groupBoxKolonlar";
            this.groupBoxKolonlar.Size = new System.Drawing.Size(323, 607);
            this.groupBoxKolonlar.TabIndex = 0;
            this.groupBoxKolonlar.TabStop = false;
            this.groupBoxKolonlar.Text = "Görüntülenecek Kolonlar  ";
            // 
            // tabPageRapor
            // 
            this.tabPageRapor.Controls.Add(this.menuStrip1);
            this.tabPageRapor.Controls.Add(this.splitContainerRapor);
            this.tabPageRapor.Location = new System.Drawing.Point(4, 25);
            this.tabPageRapor.Name = "tabPageRapor";
            this.tabPageRapor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRapor.Size = new System.Drawing.Size(1236, 688);
            this.tabPageRapor.TabIndex = 1;
            this.tabPageRapor.Text = "Rapor";
            this.tabPageRapor.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporuExceleAktarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raporuExceleAktarToolStripMenuItem
            // 
            this.raporuExceleAktarToolStripMenuItem.Name = "raporuExceleAktarToolStripMenuItem";
            this.raporuExceleAktarToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.raporuExceleAktarToolStripMenuItem.Text = "Raporu Excele Aktar";
            this.raporuExceleAktarToolStripMenuItem.Click += new System.EventHandler(this.raporuExceleAktarToolStripMenuItem_Click);
            // 
            // splitContainerRapor
            // 
            this.splitContainerRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRapor.Location = new System.Drawing.Point(3, 3);
            this.splitContainerRapor.Name = "splitContainerRapor";
            this.splitContainerRapor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRapor.Panel1
            // 
            this.splitContainerRapor.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainerRapor.Panel2
            // 
            this.splitContainerRapor.Panel2.Controls.Add(this.listBox1);
            this.splitContainerRapor.Panel2.Controls.Add(this.labelMessage2);
            this.splitContainerRapor.Size = new System.Drawing.Size(1230, 682);
            this.splitContainerRapor.SplitterDistance = 586;
            this.splitContainerRapor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 555);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(701, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(529, 88);
            this.listBox1.TabIndex = 3;
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.BackColor = System.Drawing.Color.White;
            this.labelMessage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMessage2.ForeColor = System.Drawing.Color.Red;
            this.labelMessage2.Location = new System.Drawing.Point(5, 27);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(2, 26);
            this.labelMessage2.TabIndex = 2;
            this.labelMessage2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1244, 717);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1262, 764);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAyarlar.ResumeLayout(false);
            this.tabPageAyarlar.PerformLayout();
            this.groupBoxFiltreler.ResumeLayout(false);
            this.groupBoxFiltreler.PerformLayout();
            this.tabPageRapor.ResumeLayout(false);
            this.tabPageRapor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerRapor.Panel1.ResumeLayout(false);
            this.splitContainerRapor.Panel2.ResumeLayout(false);
            this.splitContainerRapor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRapor)).EndInit();
            this.splitContainerRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAyarlar;
        private System.Windows.Forms.GroupBox groupBoxKolonlar;
        private System.Windows.Forms.TabPage tabPageRapor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporuExceleAktarToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerRapor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxFiltreler;
        private System.Windows.Forms.Label labelBitisTariihi;
        private System.Windows.Forms.Label labelBaslangicTarihi;
        private System.Windows.Forms.Label labelSorumlu;
        private System.Windows.Forms.Label labelTurAdi;
        private System.Windows.Forms.Label labelCaddeSokakPark;
        private System.Windows.Forms.Label labelMahalle;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangıc;
        private System.Windows.Forms.Label labelAygn;
        private System.Windows.Forms.Label labelAygün;
        private System.Windows.Forms.ComboBox comboBoxKayıtGirenler;
        private System.Windows.Forms.ComboBox comboBoxTurAdi;
        private System.Windows.Forms.ComboBox comboBoxCaddeSokakPark;
        private System.Windows.Forms.ComboBox comboBoxMahalle;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClear;
    }
}