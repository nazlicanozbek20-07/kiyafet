using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace kiyafet
{
   public class Program
    {
        static void Main(string[] args)
        {
            Kazak k = new Kazak();
            k.Beden = "Small";
            k.Tur = "Kadın Kazağı";
            k.Renk = "Siyah";
            k.Yaka = "Bisiklet Yaka";
            k.Desen = "Örgü";
            k.Fiyat = 90;

            Pantolon p = new Pantolon();
            p.Tur = "Kadın Pantolon";
            p.Renk = "Mavi";
            p.EnBoy = "26-24";
            p.Fiyat = 350;
            p.Marka = "Zara";
            p.PacaYapilacakMi = false;
            p.Kumas = "Kot";

            Console.WriteLine("Tür: " + k.Tur);
            Console.WriteLine("Beden: "+ k.Beden);
            Console.WriteLine("Renk: "+ k.Renk);
            Console.WriteLine("Yaka: "+ k.Yaka);
            Console.WriteLine("Desen: "+ k.Desen);
            Console.WriteLine("Fiyat: "+ k.Fiyat);
            Console.WriteLine("5 Adet Maliyeti: "+ k.MaliyetHesapla(5));
            Console.WriteLine("Sarı renk mevcut mu: " + k.RenkMevcutMu(Renkler.Kirmizi));

            Console.WriteLine("-------------------");

            Console.WriteLine("Tür: " + p.Tur);
            Console.WriteLine("En-Boy: " + p.EnBoy);
            Console.WriteLine("Renk: " + p.Renk);
            Console.WriteLine("Marka: " + p.Marka);
            Console.WriteLine("Paça Yapılacak Mı?: " + p.PacaYapilacakMi);
            Console.WriteLine("Kumaş: " + p.Kumas);
            Console.WriteLine("Fiyat: " + p.Fiyat);
            Console.WriteLine("5 Adet Maliyeti: " + p.MaliyetHesapla(5));
            Console.WriteLine("Kırmızı renk mevcut mu: " + p.RenkMevcutMu(Renkler.Gri));



            Console.ReadLine();

        }

        


    }

}
