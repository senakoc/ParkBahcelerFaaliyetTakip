namespace ParkBahcelerFaaliyetTakip
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTablolar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTabloyuAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBoxAllSelect = new System.Windows.Forms.CheckBox();
            this.ButtonTableDelete = new System.Windows.Forms.Button();
            this.ButtonNewTable = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1227, 717);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1180, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 641);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTablolar,
            this.ToolStripMenuItemTabloyuAktar,
            this.ToolStripMenuItemRapor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemTablolar
            // 
            this.ToolStripMenuItemTablolar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItemTablolar.Name = "ToolStripMenuItemTablolar";
            this.ToolStripMenuItemTablolar.Size = new System.Drawing.Size(79, 25);
            this.ToolStripMenuItemTablolar.Text = "Tablolar";
            // 
            // ToolStripMenuItemTabloyuAktar
            // 
            this.ToolStripMenuItemTabloyuAktar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExcel});
            this.ToolStripMenuItemTabloyuAktar.Name = "ToolStripMenuItemTabloyuAktar";
            this.ToolStripMenuItemTabloyuAktar.Size = new System.Drawing.Size(120, 25);
            this.ToolStripMenuItemTabloyuAktar.Text = "Tabloyu Aktar";
            // 
            // ToolStripMenuItemExcel
            // 
            this.ToolStripMenuItemExcel.Name = "ToolStripMenuItemExcel";
            this.ToolStripMenuItemExcel.Size = new System.Drawing.Size(115, 26);
            this.ToolStripMenuItemExcel.Text = "Excel";
            this.ToolStripMenuItemExcel.Click += new System.EventHandler(this.ToolStripMenuItemExcel_Click);
            // 
            // ToolStripMenuItemRapor
            // 
            this.ToolStripMenuItemRapor.Name = "ToolStripMenuItemRapor";
            this.ToolStripMenuItemRapor.Size = new System.Drawing.Size(63, 25);
            this.ToolStripMenuItemRapor.Text = "Rapor";
            this.ToolStripMenuItemRapor.Click += new System.EventHandler(this.ToolStripMenuItemRapor_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1227, 43);
            this.splitContainer2.SplitterDistance = 772;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonAdd);
            this.flowLayoutPanel1.Controls.Add(this.ButtonEdit);
            this.flowLayoutPanel1.Controls.Add(this.ButtonDelete);
            this.flowLayoutPanel1.Controls.Add(this.labelMessage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AutoSize = true;
            this.ButtonAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAdd.Location = new System.Drawing.Point(3, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(169, 37);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Kayıt Ekle";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonEdit.Location = new System.Drawing.Point(178, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(169, 37);
            this.ButtonEdit.TabIndex = 9;
            this.ButtonEdit.Text = "Düzenle";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDelete.Location = new System.Drawing.Point(353, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(169, 37);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Seçilenleri Sil";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
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
            this.labelMessage.Location = new System.Drawing.Point(528, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(2, 26);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CheckBoxAllSelect);
            this.flowLayoutPanel2.Controls.Add(this.ButtonTableDelete);
            this.flowLayoutPanel2.Controls.Add(this.ButtonNewTable);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(451, 43);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CheckBoxAllSelect
            // 
            this.CheckBoxAllSelect.AutoSize = true;
            this.CheckBoxAllSelect.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CheckBoxAllSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckBoxAllSelect.Location = new System.Drawing.Point(356, 3);
            this.CheckBoxAllSelect.Name = "CheckBoxAllSelect";
            this.CheckBoxAllSelect.Size = new System.Drawing.Size(92, 38);
            this.CheckBoxAllSelect.TabIndex = 1;
            this.CheckBoxAllSelect.Text = "Tümünü Seç";
            this.CheckBoxAllSelect.UseVisualStyleBackColor = true;
            this.CheckBoxAllSelect.Visible = false;
            // 
            // ButtonTableDelete
            // 
            this.ButtonTableDelete.AllowDrop = true;
            this.ButtonTableDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTableDelete.AutoSize = true;
            this.ButtonTableDelete.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonTableDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTableDelete.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonTableDelete.Location = new System.Drawing.Point(181, 3);
            this.ButtonTableDelete.Name = "ButtonTableDelete";
            this.ButtonTableDelete.Size = new System.Drawing.Size(169, 37);
            this.ButtonTableDelete.TabIndex = 11;
            this.ButtonTableDelete.Text = "Tabloyu Sil";
            this.ButtonTableDelete.UseVisualStyleBackColor = false;
            this.ButtonTableDelete.Click += new System.EventHandler(this.ButtonTableDelete_Click);
            // 
            // ButtonNewTable
            // 
            this.ButtonNewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewTable.AutoSize = true;
            this.ButtonNewTable.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonNewTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewTable.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonNewTable.Location = new System.Drawing.Point(6, 3);
            this.ButtonNewTable.Name = "ButtonNewTable";
            this.ButtonNewTable.Size = new System.Drawing.Size(169, 37);
            this.ButtonNewTable.TabIndex = 12;
            this.ButtonNewTable.Text = "Yeni Tablo";
            this.ButtonNewTable.UseVisualStyleBackColor = false;
            this.ButtonNewTable.Click += new System.EventHandler(this.ButtonNewTable_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1227, 717);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Park ve Bahçeler Faaliyet Takip ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox CheckBoxAllSelect;
        private System.Windows.Forms.Button ButtonTableDelete;
        private System.Windows.Forms.Button ButtonNewTable;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTablolar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTabloyuAktar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExcel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRapor;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}

