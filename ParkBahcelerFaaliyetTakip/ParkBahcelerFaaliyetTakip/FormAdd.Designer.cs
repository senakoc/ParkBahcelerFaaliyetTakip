namespace ParkBahcelerFaaliyetTakip
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cikisButon = new System.Windows.Forms.Button();
            this.ButtonKaydet = new System.Windows.Forms.Button();
            this.panelColumnName = new System.Windows.Forms.Panel();
            this.panelValues = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.cikisButon);
            this.flowLayoutPanel1.Controls.Add(this.ButtonKaydet);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(484, 691);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 67);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cikisButon
            // 
            this.cikisButon.BackColor = System.Drawing.Color.LemonChiffon;
            this.cikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButon.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButon.Location = new System.Drawing.Point(221, 3);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(140, 53);
            this.cikisButon.TabIndex = 4;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // ButtonKaydet
            // 
            this.ButtonKaydet.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKaydet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKaydet.Location = new System.Drawing.Point(75, 3);
            this.ButtonKaydet.Name = "ButtonKaydet";
            this.ButtonKaydet.Size = new System.Drawing.Size(140, 53);
            this.ButtonKaydet.TabIndex = 3;
            this.ButtonKaydet.Text = "Kaydet";
            this.ButtonKaydet.UseVisualStyleBackColor = true;
            this.ButtonKaydet.Click += new System.EventHandler(this.ButtonKaydet_Click);
            // 
            // panelColumnName
            // 
            this.panelColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColumnName.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelColumnName.Location = new System.Drawing.Point(26, 29);
            this.panelColumnName.Name = "panelColumnName";
            this.panelColumnName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelColumnName.Size = new System.Drawing.Size(276, 661);
            this.panelColumnName.TabIndex = 0;
            // 
            // panelValues
            // 
            this.panelValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValues.Location = new System.Drawing.Point(308, 29);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(520, 661);
            this.panelValues.TabIndex = 3;
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
            this.labelMessage.Location = new System.Drawing.Point(26, 709);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(2, 26);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Visible = false;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 759);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panelValues);
            this.Controls.Add(this.panelColumnName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(866, 789);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelColumnName;
        private System.Windows.Forms.Panel panelValues;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button ButtonKaydet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMessage;
    }
}