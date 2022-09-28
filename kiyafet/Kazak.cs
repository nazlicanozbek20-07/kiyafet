using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiyafet
{
    public class Kazak : IKiyafet
    {
        public string Tur { get; set; }
        public string Renk { get; set; }
        public string Yaka { get; set; }
        public string Beden { get; set; }
        public string Desen { get; set; }
        public string Ozellik1 { get; set; }
        public int Fiyat { get; set; }
        public List<Renkler> Renkler { get; set; }

        public Kazak()
        {
            Renkler = new List<Renkler>();
            Renkler.Add(kiyafet.Renkler.Kirmizi);
            Renkler.Add(kiyafet.Renkler.Gri);
            Renkler.Add(kiyafet.Renkler.Beyaz);
            Renkler.Add(kiyafet.Renkler.Siyah);
        }

        public decimal MaliyetHesapla(int adet)
        {
            return adet * this.Fiyat;
        }

        public bool RenkMevcutMu(Renkler renkler)
        {
            foreach (Renkler renk in Renkler)
            {
                if (renk == renkler)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
