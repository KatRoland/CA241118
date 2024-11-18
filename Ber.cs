using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CA241118
{
    internal class Ber
    {
        private string nev { get; set; }
        private string nem { get; set; }
        private string reszleg { get; set; }
        private int belepes { get; set; }
        private int fizetes { get; set; }

        public Ber(string line)
        {
            string[] pieces = line.Split(";");
            this.nev = pieces[0];
            this.nem = pieces[1];
            this.reszleg = pieces[2];
            this.belepes = Convert.ToInt16(pieces[3]);
            this.fizetes = Convert.ToInt32(pieces[4]);
        }

        public override string ToString()
        {
            return $"\tNév: {this.getNev()}" +
                $"\n\tNem: {this.getNem()}" +
                $"\n\tBelépés: {this.getBelepes()}" +
                $"\n\tBér: {this.getFizetes().ToString("# ###")} forint";
        }

        public string getNev()
        {
            return this.nev;
        }
        public string getNem()
        {
            return this.nem;
        }
        public string getReszleg()
        {
            return this.reszleg;
        }
        public int getBelepes()
        {
            return this.belepes;
        }

        public int getFizetes()
        {
            return this.fizetes;
        }
    }
}
