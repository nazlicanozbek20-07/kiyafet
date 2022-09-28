using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using static kiyafet.Program;



namespace kiyafet
{
    public interface IKiyafet
    {
        string Tur { get; set; }
        string Renk { get; set; }
        string Beden { get; set; }
        int Fiyat { get; set; }

        List<Renkler> Renkler { get; set; }

        decimal MaliyetHesapla(int adet);

        bool RenkMevcutMu(Renkler renkler);
      

    }
    
}
