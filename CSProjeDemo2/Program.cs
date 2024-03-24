using CSProjeDemo2.Models;
using CSProjeDemo2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            DosyaOku dosyaOku = new DosyaOku();
            List<Personel> personelListesi = dosyaOku.PersonelListesiOku("personel.json");

            MaasBordro maasBordro = new MaasBordro();
            maasBordro.MaaslariHesaplaVeKaydet(personelListesi);
            maasBordro.RaporGoruntule(personelListesi);
            maasBordro.AzCalisanlariRaporla(personelListesi);
        }
    }
}
