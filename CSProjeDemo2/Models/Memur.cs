using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Models
{
    public class Memur : Personel
    {
        public override decimal SaatlikUcret => 500;

        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal maas = calismaSaati * SaatlikUcret;
            if (calismaSaati > 180)
            {
                maas += (calismaSaati - 180) * SaatlikUcret * 0.5m; // Ek mesai ücreti
            }
            return maas;
        }
    }
}
