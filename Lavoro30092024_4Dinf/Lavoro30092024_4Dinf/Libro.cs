using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavoro30092024_4Dinf
{
    class Libro
    {
        public string Titolo { get; set;}

        public string Autore { get; set; }

        public int Pagine { get; set; }

        public decimal Costo { get; set; }

        private int Codicesegreto { get; }

        public Libro() { 
            Codicesegreto = 321;
        }

        public decimal Costoamericano() {

            decimal prezzoamericano = Costo * 0.89M;
            return prezzoamericano;
        }
    }
}
