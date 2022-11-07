using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizekutuphane
{
    public class Raf
    {
        public string Tur { get; set; }
        public List<Kitap> KitapList;

        //kitap ekle fonksiyonu
        public void KitapEkle(Kitap t_kitap)
        {
            
            KitapList.Add(t_kitap);
        }
        //kitap çıkarma fonksiyonu
        public void KitapCikar(Kitap t_kitap)
        {
            KitapList.Remove(t_kitap);
        }
    }
}
