using CSProjeDemo2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CSProjeDemo2.Services
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            List<Personel> personeller;
            using (StreamReader file = File.OpenText(dosyaYolu))
            {
                JsonSerializer serializer = new JsonSerializer();
                personeller = JsonConvert.DeserializeObject<List<Personel>>(file.ReadToEnd());
            }
            return personeller;
        }
    }
}
