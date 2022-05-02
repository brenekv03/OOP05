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
                if (value >= 10) value /= 10;
                vyska = value;
            }
        }
    }
}
