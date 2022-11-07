using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizekutuphane
{
    public class Kutuphane
    {
        public string KutuphaneIsim { get; set; }
        public List<Uye> UyeList;
        public List<Raf> RafList;
        public List<Kitap> KitapList=new List<Kitap>();
       
 

        public void UyeEkle(Uye t_uye)
        {
            UyeList.Add(t_uye);
        }

        public void UyeSil(Uye t_uye)
        {
            //uyede kitap var mı yok mu bakmak için
            if (t_uye.AldigiKitapList.Count >= 0)
            {
                MessageBox.Show("üyelik Silinmedi");
            }
            else
            {
                UyeList.Remove(t_uye); 
            }
                   
                    
            }

       

        public void RafEkle(Raf t_raf)
        {
            RafList.Add(t_raf);
        }

        public void RafSil(Raf t_raf)
        {
            RafList.Remove(t_raf);
        }
         
        public void KitapEkle(Kitap t_kitap)
        {
            KitapList.Add(t_kitap);
        }

    }
}
