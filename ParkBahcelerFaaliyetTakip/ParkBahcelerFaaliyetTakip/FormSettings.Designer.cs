namespace ParkBahcelerFaaliyetTakip
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRowCancel = new System.Windows.Forms.Button();
            this.buttonRowFont = new System.Windows.Forms.Button();
            this.buttonRowForeColor = new System.Windows.Forms.Button();
            this.buttonRowBackColor = new System.Windows.Forms.Button();
            this.labelRow = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelColumn = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonColumnCancel = new System.Windows.Forms.Button();
            this.buttonColumnFont = new System.Windows.Forms.Button();
            this.buttonColumnForeColor = new System.Windows.Forms.Button();
            this.buttonColumnBackColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonRowCancel);
            this.groupBox1.Controls.Add(this.buttonRowFont);
            this.groupBox1.Controls.Add(this.buttonRowForeColor);
            this.groupBox1.Controls.Add(this.buttonRowBackColor);
            this.groupBox1.Location = new System.Drawing.Point(45, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablo satırları için";
            // 
            // buttonRowCancel
            // 
            this.buttonRowCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRowCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonRowCancel.Image")));
            this.buttonRowCancel.Location = new System.Drawing.Point(619, 80);
            this.buttonRowCancel.Name = "buttonRowCancel";
            this.buttonRowCancel.Size = new System.Drawing.Size(38, 34);
            this.buttonRowCancel.TabIndex = 14;
            this.buttonRowCancel.UseVisualStyleBackColor = true;
            this.buttonRowCancel.Click += new System.EventHandler(this.buttonRowCancel_Click);
            // 
            // buttonRowFont
            // 
            this.buttonRowFont.AutoSize = true;
            this.buttonRowFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRowFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRowFont.Location = new System.Drawing.Point(9, 38);
            this.buttonRowFont.Name = "buttonRowFont";
            this.buttonRowFont.Size = new System.Drawing.Size(152, 29);
            this.buttonRowFont.TabIndex = 12;
            this.buttonRowFont.Text = "Yazı Stilini Seç";
            this.buttonRowFont.UseVisualStyleBackColor = true;
            this.buttonRowFont.Click += new System.EventHandler(this.buttonRowFont_Click);
            // 
            // buttonRowForeColor
            // 
            this.buttonRowForeColor.AutoSize = true;
            this.buttonRowForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRowForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRowForeColor.Location = new System.Drawing.Point(231, 38);
            this.buttonRowForeColor.Name = "buttonRowForeColor";
            this.buttonRowForeColor.Size = new System.Drawing.Size(152, 29);
            this.buttonRowForeColor.TabIndex = 11;
            this.buttonRowForeColor.Text = "Yazı Rengi Seç";
            this.buttonRowForeColor.UseVisualStyleBackColor = true;
            this.buttonRowForeColor.Click += new System.EventHandler(this.buttonRowForeColor_Click);
            // 
            // buttonRowBackColor
            // 
            this.buttonRowBackColor.AutoSize = true;
            this.buttonRowBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRowBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRowBackColor.Location = new System.Drawing.Point(450, 38);
            this.buttonRowBackColor.Name = "buttonRowBackColor";
            this.buttonRowBackColor.Size = new System.Drawing.Size(152, 29);
            this.buttonRowBackColor.TabIndex = 10;
            this.buttonRowBackColor.Text = "Arka Plan Rengi Seç";
            this.buttonRowBackColor.UseVisualStyleBackColor = true;
            this.buttonRowBackColor.Click += new System.EventHandler(this.buttonRowBackColor_Click);
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRow.Location = new System.Drawing.Point(754, 120);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(83, 19);
            this.labelRow.TabIndex = 12;
            this.labelRow.Text = "Satır örneği";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColumn.Location = new System.Drawing.Point(754, 267);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(90, 19);
            this.labelColumn.TabIndex = 13;
            this.labelColumn.Text = "Kolon örneği";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.buttonColumnCancel);
            this.groupBox2.Controls.Add(this.buttonColumnFont);
            this.groupBox2.Controls.Add(this.buttonColumnForeColor);
            this.groupBox2.Controls.Add(this.buttonColumnBackColor);
            this.groupBox2.Location = new System.Drawing.Point(45, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 130);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablo kolon isimleri  için";
            // 
            // buttonColumnCancel
            // 
            this.buttonColumnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonColumnCancel.Image")));
            this.buttonColumnCancel.Location = new System.Drawing.Point(619, 80);
            this.buttonColumnCancel.Name = "buttonColumnCancel";
            this.buttonColumnCancel.Size = new System.Drawing.Size(38, 34);
            this.buttonColumnCancel.TabIndex = 16;
            this.buttonColumnCancel.UseVisualStyleBackColor = true;
            this.buttonColumnCancel.Click += new System.EventHandler(this.buttonColumnCancel_Click);
            // 
            // buttonColumnFont
            // 
            this.buttonColumnFont.AutoSize = true;
            this.buttonColumnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonColumnFont.Location = new System.Drawing.Point(9, 43);
            this.buttonColumnFont.Name = "buttonColumnFont";
            this.buttonColumnFont.Size = new System.Drawing.Size(152, 29);
            this.buttonColumnFont.TabIndex = 12;
            this.buttonColumnFont.Text = "Yazı Stilini Seç";
            this.buttonColumnFont.UseVisualStyleBackColor = true;
            this.buttonColumnFont.Click += new System.EventHandler(this.buttonColumnFont_Click);
            // 
            // buttonColumnForeColor
            // 
            this.buttonColumnForeColor.AutoSize = true;
            this.buttonColumnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonColumnForeColor.Location = new System.Drawing.Point(231, 43);
            this.buttonColumnForeColor.Name = "buttonColumnForeColor";
            this.buttonColumnForeColor.Size = new System.Drawing.Size(152, 29);
            this.buttonColumnForeColor.TabIndex = 11;
            this.buttonColumnForeColor.Text = "Yazı Rengi Seç";
            this.buttonColumnForeColor.UseVisualStyleBackColor = true;
            this.buttonColumnForeColor.Click += new System.EventHandler(this.buttonColumnForeColor_Click);
            // 
            // buttonColumnBackColor
            // 
            this.buttonColumnBackColor.AutoSize = true;
            this.buttonColumnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColumnBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonColumnBackColor.Location = new System.Drawing.Point(450, 43);
            this.buttonColumnBackColor.Name = "buttonColumnBackColor";
            this.buttonColumnBackColor.Size = new System.Drawing.Size(152, 29);
            this.buttonColumnBackColor.TabIndex = 10;
            this.buttonColumnBackColor.Text = "Arka Plan Rengi Seç";
            this.buttonColumnBackColor.UseVisualStyleBackColor = true;
            this.buttonColumnBackColor.Click += new System.EventHandler(this.buttonColumnBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaydı Giren Kisi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.labelMessage.Location = new System.Drawing.Point(51, 422);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(2, 26);
            this.labelMessage.TabIndex = 16;
            this.labelMessage.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(634, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tüm Değişiklikleri Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonRowBackColor;
        private System.Windows.Forms.Button buttonRowForeColor;
        private System.Windows.Forms.Button buttonRowFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonColumnFont;
        private System.Windows.Forms.Button buttonColumnForeColor;
        private System.Windows.Forms.Button buttonColumnBackColor;
        public System.Windows.Forms.Label labelRow;
        public System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Button buttonRowCancel;
        private System.Windows.Forms.Button buttonColumnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button button1;
    }
}