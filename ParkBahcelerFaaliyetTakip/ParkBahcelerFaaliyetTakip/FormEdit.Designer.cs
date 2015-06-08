namespace ParkBahcelerFaaliyetTakip
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.panelColumnName = new System.Windows.Forms.Panel();
            this.panelValues = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.TextBoxSatirNo = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cikisButon = new System.Windows.Forms.Button();
            this.ButtonKaydet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColumnName
            // 
            resources.ApplyResources(this.panelColumnName, "panelColumnName");
            this.panelColumnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColumnName.Name = "panelColumnName";
            // 
            // panelValues
            // 
            resources.ApplyResources(this.panelValues, "panelValues");
            this.panelValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValues.Name = "panelValues";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ButtonNext, "ButtonNext");
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ButtonPrev, "ButtonPrev");
            this.ButtonPrev.FlatAppearance.BorderSize = 0;
            this.ButtonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.UseVisualStyleBackColor = false;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // TextBoxSatirNo
            // 
            this.TextBoxSatirNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSatirNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxSatirNo, "TextBoxSatirNo");
            this.TextBoxSatirNo.Name = "TextBoxSatirNo";
            this.TextBoxSatirNo.TextChanged += new System.EventHandler(this.SatirNoTextBox_Changed);
            this.TextBoxSatirNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RakamKontrolu);
            // 
            // labelMessage
            // 
            resources.ApplyResources(this.labelMessage, "labelMessage");
            this.labelMessage.BackColor = System.Drawing.Color.White;
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Name = "labelMessage";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.cikisButon);
            this.flowLayoutPanel1.Controls.Add(this.ButtonKaydet);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // cikisButon
            // 
            this.cikisButon.BackColor = System.Drawing.Color.LemonChiffon;
            resources.ApplyResources(this.cikisButon, "cikisButon");
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // ButtonKaydet
            // 
            this.ButtonKaydet.BackColor = System.Drawing.Color.LemonChiffon;
            resources.ApplyResources(this.ButtonKaydet, "ButtonKaydet");
            this.ButtonKaydet.Name = "ButtonKaydet";
            this.ButtonKaydet.UseVisualStyleBackColor = true;
            this.ButtonKaydet.Click += new System.EventHandler(this.ButtonKaydet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelValues);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.panelColumnName);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.TextBoxSatirNo);
            this.Name = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColumnName;
        private System.Windows.Forms.Panel panelValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.TextBox TextBoxSatirNo;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button ButtonKaydet;
        private System.Windows.Forms.Timer timer1;
    }
}