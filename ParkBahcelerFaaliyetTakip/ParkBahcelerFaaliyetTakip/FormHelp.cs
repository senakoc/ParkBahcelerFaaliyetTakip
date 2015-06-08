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
    public partial class FormHelp : Form
    {
        public FormAddTable addtable;
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "\n" +
                "Kolon tipleri; "+
                "\n[int] : Bu kolon tipi rakamsal verileri tutar. "+
                "\n[date]  : Bu kolon timi tarih bilgisini tutar."+
                "\n[nvarchar](50)  : Bu kolon tipi 50 karakterlik kelime tutar." +
                "\nOtomatik Hesaplanan Kolon : Eğer değeri aynı tablodaki diğer kolonlardan bir veya birkaçına bağlı olarak değişen bir kolona ihtiyacınız varsa bu durumda bu tipi kullanabilirsiniz. Kolon isimlerini girerken örnekteki gibi [ ] işaretleri arasına yazmaya özen gösteriniz." +
                "\nÖrneğin: ([Kolon1] + [Kolon2]) * [Kolon3]" +
                "\n\nProgramdan tam anlamıyla yararlanabilmek için;" +
                "\nEğer mahalle isimlerini tutacağınız bir kolona ihtiyaç varsa lütfen kolon ismini Mahalle olarak girin." +
                "\nEğer cadde, sokak, park isimlerini tutacağınız bir kolona ihtiyaç varsa lütfen kolon ismini CaddeSokakPark olarak girin." +
                "\nEğer tür isimlerini saklayacağınız bir kolona ihtiyaç varsa lütfen kolon ismini TurAdi olarak girin." +
                "\nEğer tarih değerlerinin tutulacağı bir kolona ihtiyaç varsa lütfen kolon ismini Tarih olarak girin." ;
        }
    }
}
