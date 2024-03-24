using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Yonetici : Personel
    {
        public override decimal SaatlikUcret => 500;

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal maas = calismaSaati * SaatlikUcret;
            // Bonus ekleme mantığı burada
            return maas;
        }
    }
}
