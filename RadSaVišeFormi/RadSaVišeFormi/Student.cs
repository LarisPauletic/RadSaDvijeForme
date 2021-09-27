using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaVišeFormi
{
    class Student
    {
        private string ime, prezime, brojIndeksa, smjer;
        private DateTime datumRodjenja;

        private string Ime { get => ime; set => ime = value; }
        private string Prezime { get => prezime; set => prezime = value; }
        private string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        private string Smjer { get => smjer; set => smjer = value; }
        private DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()
        {
            return base.ToString();
            
        }
    }
}
