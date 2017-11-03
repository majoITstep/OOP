using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Chata : Dom
    {
        private string spolocenskaMiestnost;
        public Chata(string nazov, string typ, string poschodie, int obytneMiestnosti, float uzitkovaPlocha, float zastavanaPlocha, string spolocenskaMiestnost): base(nazov, typ, poschodie, obytneMiestnosti,uzitkovaPlocha,zastavanaPlocha)
        {
            this.spolocenskaMiestnost = spolocenskaMiestnost;
        }

        public void PopisChaty()
        {
            Console.WriteLine("Nazov chaty: {0}", this.nazov);
            Console.WriteLine("Spolocenska miestnost: {0}", spolocenskaMiestnost);
        }
    }
}
