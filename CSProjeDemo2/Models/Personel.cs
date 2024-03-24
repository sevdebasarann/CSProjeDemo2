using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract decimal SaatlikUcret { get; }
        public abstract decimal MaasHesapla(int calismaSaati);
    }
}
