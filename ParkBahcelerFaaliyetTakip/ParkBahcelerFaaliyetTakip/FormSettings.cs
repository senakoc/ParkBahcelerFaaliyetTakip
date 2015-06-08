using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParkBahcelerFaaliyetTakip
{
    public partial class FormSettings : Form
    {
        #region Global değişkenler
        public bool exsistChanged = false;
        private string kayıtgiren = string.Empty;

        private Font rowFont;
        private Color rowForeColor;
        private Color rowBackColor;

        private Font ColumnFont;
        private Color ColumnForeColor;
        private Color ColumnBackColor;

        string fontRowString;
        string fontColumnString;
        //timer
        private int timerCount = 3;
        private bool savedChanged = false;
        private bool eror = false;
        public FormMain main;
        #endregion

        #region FormSettins
        public FormSettings()
        {
            InitializeComponent();
        }
        #endregion

        #region Formsettings Load
        private void FormSettings_Load(object sender, EventArgs e)
        {
            exsistChanged = false;

            rowFont = labelRow.Font = main.ROWfont;
            rowBackColor = labelRow.BackColor = main.ROWbackColor;
            rowForeColor = labelRow.ForeColor = main.ROWforecolor;

            ColumnFont = labelColumn.Font = main.COLUMNfont;
            ColumnBackColor = labelColumn.BackColor = main.COLUMNbackColor;
            ColumnForeColor = labelColumn.ForeColor = main.COLUMNforecolor;

            textBox1.Text = main.kayitGiren;
        }
        #endregion

        #region Satır fontu
        private void buttonRowFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                main.defaultStyle.Font = labelRow.Font = rowFont = fontDialog1.Font;
            }
        }
        #endregion

        #region satır ön rengi
        private void buttonRowForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                main.defaultStyle.SelectionForeColor = main.defaultStyle.ForeColor = labelRow.ForeColor = rowForeColor = colorDialog1.Color;
            }
        }
        #endregion 

        #region satır arkaplan rengi
        private void buttonRowBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                main.defaultStyle.SelectionBackColor = main.defaultStyle.BackColor = labelRow.BackColor = rowBackColor = colorDialog1.Color;
                rowBackColor = colorDialog1.Color;
            }
        }
        #endregion

        #region Kolon fontu
        private void buttonColumnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                main.Columnstyle.Font = labelColumn.Font = ColumnFont =  fontDialog1.Font;
            }
        }
        #endregion

        #region Kolon ön rengi
        private void buttonColumnForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                main.Columnstyle.SelectionForeColor = main.Columnstyle.ForeColor = labelColumn.ForeColor = ColumnForeColor = colorDialog1.Color;
            }
        }
        #endregion
        
        #region Kolon arka plan rengi
        private void buttonColumnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                main.Columnstyle.SelectionBackColor = main.Columnstyle.BackColor = labelColumn.BackColor = ColumnBackColor = colorDialog1.Color;
            }
        }
        #endregion

        #region kaydı giren
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kayıtgiren = textBox1.Text.Trim();
        }
        #endregion

        #region Satır stil değişklikleri iptal
        private void buttonRowCancel_Click(object sender, EventArgs e)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            main.defaultStyle.Font = labelRow.Font = rowFont = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular);
            main.defaultStyle.SelectionBackColor = main.defaultStyle.BackColor = labelRow.BackColor = rowBackColor = System.Drawing.Color.White;
            main.defaultStyle.SelectionForeColor = main.defaultStyle.ForeColor = labelRow.ForeColor = rowForeColor = System.Drawing.Color.Black;
            fontRowString = tc.ConvertToString(rowFont);
        }
        #endregion

        #region Kolon stil değişiklikleri iptal
        private void buttonColumnCancel_Click(object sender, EventArgs e)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            main.Columnstyle.Font = labelColumn.Font = ColumnFont = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Italic);
            main.Columnstyle.SelectionBackColor = main.Columnstyle.BackColor = labelColumn.BackColor = ColumnBackColor = System.Drawing.Color.LightGray;
            main.Columnstyle.SelectionForeColor = main.Columnstyle.ForeColor = labelColumn.ForeColor = ColumnForeColor = System.Drawing.SystemColors.WindowText;
            fontColumnString = tc.ConvertToString(ColumnFont);
            
        }
        #endregion

        #region xml
        private bool xmlWriter() 
        {

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            fontColumnString = tc.ConvertToString(ColumnFont);
            fontRowString = tc.ConvertToString(rowFont);

            XmlTextWriter writer = new XmlTextWriter("Settings.xml", System.Text.UTF8Encoding.UTF8);
            try
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("SAVED");

                writer.WriteStartElement("KISI");
                writer.WriteString(kayıtgiren);
                writer.WriteEndElement();//title

                #region satır stilleri
                writer.WriteStartElement("FONTROW");
                writer.WriteString(fontRowString);
                writer.WriteEndElement();//FONTROW
                writer.WriteStartElement("FONTROWFORECOLOR");
                writer.WriteString(rowForeColor.ToArgb().ToString());
                writer.WriteEndElement();//FONTROWFORECOLOR
                writer.WriteStartElement("FONTROWBACKCOLOR");
                writer.WriteString(rowBackColor.ToArgb().ToString());
                writer.WriteEndElement();//FONTROWBACKCOLOR
                #endregion

                #region kolon stilleri
                writer.WriteStartElement("FONTCOLUMN");
                writer.WriteString(fontColumnString);
                writer.WriteEndElement();//FONTROW
                writer.WriteStartElement("FONTCOLUMNFORECOLOR");
                writer.WriteString(ColumnForeColor.ToArgb().ToString());
                writer.WriteEndElement();//FONTROWFORECOLOR
                writer.WriteStartElement("FONTCOLUMNBACKCOLOR");
                writer.WriteString(ColumnBackColor.ToArgb().ToString());
                writer.WriteEndElement();//FONTROWBACKCOLOR
                #endregion

                writer.WriteEndElement();//saved

                writer.WriteEndDocument();
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 1. DEğişiklikler kaydedildi
            if (savedChanged)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Değişiklikler kayıt edildi..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 0;
                    savedChanged = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1. END

            #region 1. DEğişiklikler kaydedilemedi
            if (eror)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Değişiklikler kayıt edilemedi..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 0;
                    eror = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1. END
        }
        #endregion

        #region xml'e kayıt
        private void button1_Click(object sender, EventArgs e)
        {
            exsistChanged = true;
            ColumnFont = main.Columnstyle.Font = labelColumn.Font;
            ColumnForeColor =  main.Columnstyle.ForeColor = labelColumn.ForeColor;
            ColumnBackColor = main.Columnstyle.BackColor = labelColumn.BackColor;
            main.Columnstyle.SelectionBackColor = labelColumn.BackColor;
            main.Columnstyle.SelectionBackColor = labelColumn.ForeColor;

            rowFont = main.defaultStyle.Font = labelRow.Font;
            rowForeColor = main.defaultStyle.ForeColor = labelRow.ForeColor;
            rowBackColor = main.defaultStyle.BackColor = labelRow.BackColor;
            main.defaultStyle.SelectionForeColor = labelRow.ForeColor;
            main.defaultStyle.SelectionBackColor = labelRow.BackColor;

            if (xmlWriter())
            {
                savedChanged = true;
                timer1.Enabled = true;
            }
            else
            {
                eror = true;
                timer1.Enabled = true;
            }
        }
        #endregion





    }
}


  //ColumnFont = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Italic);
  //          ColumnBackColor = System.Drawing.Color.LightGray;
  //          ColumnForeColor = System.Drawing.SystemColors.WindowText;

  //          rowFont = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular);
  //          rowBackColor = System.Drawing.Color.White;
  //          rowForeColor = System.Drawing.Color.Black;