using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vizekutuphane
{
    internal class Uye
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public List<Kitap> AldigiKitapList;
        public List<Kitap> EskiAldigiKitapList;


        public void Kirala(Kitap t_kitap)
        {
            EskiAldigiKitapList.Add(t_kitap);
            t_kitap.Kirala(this);

        }
        //kiatp çikarma
        public void KiralikSonlandir(Kitap t_kitap)
        {
            AldigiKitapList.Remove(t_kitap);
            EskiAldigiKitapList.Add(t_kitap);
            t_kitap.KiralikSonlandir();
        }

    }
}
