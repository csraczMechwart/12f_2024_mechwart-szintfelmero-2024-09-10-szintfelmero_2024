using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class dolgok
    {
        public dolgok(int fordulo, int hazaigolok, int vendeggolok, int hazaifelidogolok, int vendegfelidogolok, string hazaicsapatnev, string vendegcsapatnev)
        {
            Fordulo = fordulo;
            Hazaigolok = hazaigolok;
            Vendeggolok = vendeggolok;
            Hazaifelidogolok = hazaifelidogolok;
            Vendegfelidogolok = vendegfelidogolok;
            Hazaicsapatnev = hazaicsapatnev;
            Vendegcsapatnev = vendegcsapatnev;
        }

        public int Fordulo { get; set; }
        public int Hazaigolok { get; set; }
        public int Vendeggolok { get; set; }
        public int Hazaifelidogolok { get; set; }
        public int Vendegfelidogolok { get; set; }
        public string Hazaicsapatnev {  get; set; }
        public string Vendegcsapatnev { get; set; }
    }
}
