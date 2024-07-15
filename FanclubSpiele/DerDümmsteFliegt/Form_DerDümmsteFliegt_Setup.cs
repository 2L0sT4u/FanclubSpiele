using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele
{
    public partial class Form_DerDümmsteFliegt_Setup : Form
    {
        public Form_DerDümmsteFliegt_Setup(int anzahlSpieler_)
        {
            InitializeComponent();
            setAnzahlSpieler(anzahlSpieler_);
            MinFragenEmpfohlen();

        }
        public int anzahlSpieler = 0;
        private void setAnzahlSpieler(int anzahl)
        {
            anzahlSpieler = anzahl;
        }

        //Funktionen
        private void MinFragenEmpfohlen()
        {
            int minFragen = 0;
            int spielerLeben = Convert.ToInt32(SpielerLeben_nmupdwn.Value);
            int rundenZeit = Convert.ToInt32(rundenZeit_nmupdwn.Value);
            int spielerAnzahl = anzahlSpieler;

            minFragen = spielerAnzahl*spielerLeben*(rundenZeit/10);
            EmpfFragen_lbl.Text = $"(Mindestens {minFragen} Fragen empfohlen)";
        }

        //Events
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MinFragenEmpfohlen();
        }

        private void rundenZeit_nmupdwn_ValueChanged(object sender, EventArgs e)
        {
            MinFragenEmpfohlen();
        }
    }
}
