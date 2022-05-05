using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    class Pacient:Osoba
    {
        public double ObvodPasu { get; set; }
        public Pacient(string jmeno, string prijmeni, double obvodPasu) : base(jmeno, prijmeni)
        {
            ObvodPasu = obvodPasu;
        }
        public double ABSI()
        {
           return ObvodPasu / (Math.Pow(BMI(),2/3) * Math.Sqrt(Vyska));
        }
        public override string ToString()
        {
            return base.ToString() + "\nABSI je: " + ABSI();
        }
    }
}
