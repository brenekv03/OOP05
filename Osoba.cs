using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    class Osoba
    {
        private double hmotnost;
        private double vyska;
        public string Jmeno { get; }
        public string Prijmeni { get; set; }
        public double Hmotnost 
        {
            get 
            { 
                return hmotnost;
            }
            set 
            {
                if (value <= 0 && value > 300) System.Windows.Forms.MessageBox.Show("Hmotnost mimo rozsah");
                else hmotnost = value;
            }
        }
        public double Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if (value >= 2.5) value /= 100;
                vyska = value;
            }
        }
        public Osoba(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public virtual double BMI()
        {
            double bmi = Hmotnost / (Vyska*Vyska);
            return bmi;
        }
        public override string ToString()
        {
            string s = "\nJméno je: " + Jmeno
                + "\nPříjmení je: " + Prijmeni
                + "\nVýška v metrech: " + Vyska
                + "\nHmotnost je: " + Hmotnost
                + "\nIndex BMI: " + BMI();
            return base.ToString()+s;
        }
    }
}
