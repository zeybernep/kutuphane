using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizekutuphane
{
    public partial class Form1 : Form
    {
        Kutuphane kutuphane = new Kutuphane();
        public Form1()
        {
            InitializeComponent();
            KitapGrid.DataSource = kutuphane.KitapList;

            var list = kutuphane.KitapList;

            var bindingList= new BindingList<Kitap>(list);
            var source = new BindingSource(bindingList, null);
            KitapGrid.DataSource=source;
        }




        //LABEL1_CLİCK VE LABEL3_CLİCK YANLIŞLIKLA BASTIM
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------



        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Yazar = YazarAdi.Text;
            kitap.Tur = "polisiye";
            kitap.Kitapadi=KitapAdi.Text;
            kitap.BasimYili=Convert.ToUInt32(BasimYili.Text); 
            
            kutuphane.KitapList.Add(kitap);

            
            KitapGrid.Refresh();
        }
    }
}
