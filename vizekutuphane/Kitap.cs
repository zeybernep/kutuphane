using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizekutuphane
{
    public class Kitap
    {
        public uint UID; //unique ID
        public string Kitapadi;
        public string Yazar;
        public string Yayinevi;
        public string Tur;
        public uint BasimYili;


        public Uye Sahip; //bir kitap birden fazla üyeye sahip olabilir
            

        public List<Uye> EskiSahipler;  //sahipleri tutmak için


        //kitap eklemek için 
        public void Kirala(Uye t_uye)
        {
            Sahip = t_uye;
        }   
            
         //kiralık sonlandırma
        public void KiralikSonlandir()
        {
            EskiSahipler.Add(Sahip); //eski sahipleri sahiplere ekledim
            Sahip = null;
        }
        


    }
}
