using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba os1 = new Osoba("Pavel", "Bodnar");
            os1.Hmotnost = 75;
            os1.Vyska = 1.85;
            os1.BMI();
            MessageBox.Show( os1.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacient pc1 = new Pacient("Lakatoš", "Bodnaroš", 0.5);
            pc1.Hmotnost = 80;
            pc1.Vyska = 1.80;
            pc1.ABSI();
            MessageBox.Show(pc1.ToString());
        }
    }
}
