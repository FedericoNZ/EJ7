using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            var sumaDe10 = BilletesDe10 * 10m;
            var sumaDe20 = BilletesDe20 * 20m;
            var sumaDe50 = BilletesDe50 * 50m;
            var sumaDe100 = BilletesDe100 * 100m;
            var sumaDe200 = BilletesDe200 * 200m;
            var sumaDe500 = BilletesDe500 * 500m;
            var sumaDe1000 = BilletesDe1000 * 1000m;
            decimal sumaTotal = sumaDe10 + sumaDe20 + sumaDe50 + sumaDe100 + sumaDe200 + sumaDe500 + sumaDe1000;
            return sumaTotal;
        }

        public Billetera Combinar(Billetera segundaBilletera)
        {
            Billetera nuevaBilletera = new Billetera()
            {
                BilletesDe10 = BilletesDe10 + segundaBilletera.BilletesDe10,
                BilletesDe20 = BilletesDe20 + segundaBilletera.BilletesDe20,
                BilletesDe50 = BilletesDe50 + segundaBilletera.BilletesDe50,
                BilletesDe100 = BilletesDe100 + segundaBilletera.BilletesDe100,
                BilletesDe200 = BilletesDe200 + segundaBilletera.BilletesDe200,
                BilletesDe500 = BilletesDe500 + segundaBilletera.BilletesDe500,
                BilletesDe1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000,
            };
            BilletesDe10 = segundaBilletera.BilletesDe10 = 0;
            BilletesDe20 = segundaBilletera.BilletesDe20 = 0;
            BilletesDe50 = segundaBilletera.BilletesDe50 = 0;
            BilletesDe100 = segundaBilletera.BilletesDe100 = 0;
            BilletesDe200 = segundaBilletera.BilletesDe200 = 0;
            BilletesDe500 = segundaBilletera.BilletesDe500 = 0;
            BilletesDe1000 = segundaBilletera.BilletesDe1000 = 0;
            return nuevaBilletera;
        }
    }
}
