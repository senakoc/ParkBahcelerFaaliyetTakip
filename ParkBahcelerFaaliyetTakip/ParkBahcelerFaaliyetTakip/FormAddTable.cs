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
    public partial class FormAddTable : Form
    {
        #region Global değişkenler

        private string columnName = string.Empty;
        private string columnType = string.Empty;
        private string computedColumn = string.Empty;
        private string sorguKolon = string.Empty;

        private int maxColumnCount = 15;
        private int columnCount = 1;

        private int timerCount = 3;
        private bool addingTableFail = false;
        private bool addingTableSuccessful = false;
        
        public FormMain main;
        public FormHelp help;

        #endregion Global END
       
        #region 1. FormAddTable
        public FormAddTable()
        {
            help = new FormHelp();
            help.addtable = this;
            InitializeComponent();
        }
        #endregion 1.END
       
        #region 2. Help butonu
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            help.ShowDialog();
        }
        #endregion 2. END

        #region 3. Listboxa kolon ismi tipi eklenmesi
        private void addListbox()
        {
            if (columnCount <= maxColumnCount)
            {
                if (textBox1.Visible)
                {
                    if (textBox1.Text != "örneğin: (Kolon1 + Kolon2) * Kolon3")
                    {
                        listBox1.Items.Add("[" + columnName + "] AS (" + computedColumn + "), ");
                    }
                    comboBoxColumnType.SelectedIndex = -1;
                }
                else
                {
                    listBox1.Items.Add("[" + columnName + "] " + columnType + " NOT NULL, ");
                    columnCount++;
                }
            }
        }
        #endregion 3. END 

        #region 4. Kolon isminin girilmesi
        private void ColumnNameChanged(object sender, EventArgs e)
        {
            if (columnCount <= maxColumnCount)
            {
                columnName = textBoxColumnName.Text.Trim();
            }
            else
                textBoxColumnName.Enabled = false;
        }
        #endregion 4. END

        #region 5. Kolon tipinin seçilmesi
        private void ColumnTypeChanged(object sender, EventArgs e)
        {
            if ((columnName != string.Empty) && (columnCount <= maxColumnCount) && comboBoxColumnType.SelectedIndex != -1)
            {
                if (comboBoxColumnType.SelectedIndex != 3)
                {
                    textBox1.Visible = false;
                    button1.Visible = false;
                    columnType = comboBoxColumnType.SelectedItem.ToString();
                    addListbox();
                    textBoxColumnName.Text = "";
                    comboBoxColumnType.SelectedIndex = -1;
                }
                else
                {
                    textBox1.Visible = true;
                    button1.Visible = true;
                    textBox1.Text = "örneğin: ([Kolon1] + [Kolon2]) * [Kolon3]";
                }

            }
            else if (columnCount > maxColumnCount)
            {
                comboBoxColumnType.Enabled = false;
            }
        }
        #endregion 5.END

        #region 6. Otomatik hesaplama kolonunu ekle
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "örneğin: ((Kolon1 + Kolon2) * Kolon3)")
            {
                addListbox();
                textBox1.Visible = false;
                button1.Visible = false;
                textBoxColumnName.Text = "";
                comboBoxColumnType.SelectedIndex = -1;
            }
        }
        #endregion 6. END

        #region 7. Çift tıklama ile silme
        private void DoubleClickColumnNAme(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            columnCount--;
            if (columnCount <= maxColumnCount)
            {
                textBoxColumnName.Enabled = true;
                comboBoxColumnType.Enabled = true;
            }
        }
        #endregion 7. END

        #region 8. Formülün alınması
        private void kolonhesabi(object sender, EventArgs e)
        {
            computedColumn = textBox1.Text.Trim();
        }
        #endregion 8. END

        #region 9. KAydet butonu
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxTableName.Text != string.Empty)
            {
                string sorgu = "if not exists (select * from sysobjects where name='[" + main.databaseName + "].[dbo].[" + textBoxTableName.Text + "]')" +
                              "CREATE TABLE [" + main.databaseName + "].[dbo].[" + textBoxTableName.Text + "] ( [KayitNo] [int] IDENTITY(1,1) NOT NULL, ";
                foreach (string item in listBox1.Items)
                {
                    sorgu += item;
                }
                sorgu += "[KaydiGirenKisi] [nvarchar](50) NOT NULL CONSTRAINT [PK_" + textBoxTableName.Text + "] PRIMARY KEY CLUSTERED ([KayitNo] ASC)" +
                "WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]";
                try
                {
                    int result = main.getExectuQuery(sorgu);
                    if (result != 0)
                    {
                        main.ToolStripMenuItemAdd();
                        addingTableSuccessful = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        addingTableFail = true;
                        timer1.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu\n"+ex.Message);
                    throw;
                }
            }
        }
        #endregion 9. END
        
        #region 10. iptal butonu
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion 10. END

        #region 11. Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 1. Tablo eklenemediyse
            if (addingTableFail)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo eklenemedi..."+timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    addingTableFail = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 1. END

            #region 2. Tablo eklendiyse
            if (addingTableSuccessful)
            {
                if (timerCount != 0)
                {
                    labelMessage.Visible = true;
                    labelMessage.Text = "Tablo başarıyla eklendi..." + timerCount;
                    timerCount--;
                }
                else
                {
                    labelMessage.Text = "";
                    labelMessage.Visible = false;
                    timerCount = 3;
                    addingTableSuccessful = false;
                    timer1.Enabled = false;
                }
            }
            #endregion 2.END
        }
        #endregion 11. END
    }
}
