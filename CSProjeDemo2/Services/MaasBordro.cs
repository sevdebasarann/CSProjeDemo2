using CSProjeDemo2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSProjeDemo2.Services
{
    public class MaasBordro
    {
        public void MaaslariHesaplaVeKaydet(List<Personel> personelListesi)
        {
            foreach (Personel personel in personelListesi)
            {
                decimal maas = personel.MaasHesapla(180); // Örnek çalışma saati
                string dosyaYolu = $"{personel.Ad}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json";
                Kaydet(personel, maas, dosyaYolu);
            }
        }

        public void RaporGoruntule(List<Personel> personelListesi)
        {
            foreach (Personel personel in personelListesi)
            {
                Console.WriteLine($"{personel.Ad}: {personel.MaasHesapla(180):C}");
            }
        }

        public void AzCalisanlariRaporla(List<Personel> personelListesi)
        {
            foreach (Personel personel in personelListesi)
            {
                if (personel.MaasHesapla(150) < 150 * personel.SaatlikUcret)
                {
                    Console.WriteLine($"{personel.Ad} {personel.Soyad} az çalışan personeldir.");
                }
            }
        }

        private void Kaydet(Personel personel, decimal maas, string dosyaYolu)
        {
            var data = new
            {
                PersonelIsmi = $"{personel.Ad} {personel.Soyad}",
                CalismaSaati = 180, // Örnek çalışma saati
                AnaOdeme = personel.MaasHesapla(180),
                ToplamOdeme = maas
            };

            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dosyaYolu, json);
        }
    }
}
