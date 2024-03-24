using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using CSProjeDemo2.Services;


namespace CSProjeDemo2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = @"..\CSProjeDemo2\Data\personel.json";
           

            DosyaOku dosyaOku = new DosyaOku();
            List<Personel> personelListesi = dosyaOku.PersonelListesiOku(dosyaYolu);

            MaasBordro maasBordro = new MaasBordro();
            maasBordro.MaaslariHesaplaVeKaydet(personelListesi);
            maasBordro.RaporGoruntule(personelListesi);
            maasBordro.AzCalisanlariRaporla(personelListesi);

            Console.ReadLine();
        }
    }
}
