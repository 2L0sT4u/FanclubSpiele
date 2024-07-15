using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FanclubSpiele.Jeopardy;
using FanclubSpiele.JeoPardy;

namespace FanclubSpiele
{
    public partial class Form_Spiele : Form
    {
        public Form_Spiele()
        {
            InitializeComponent();
        }


        //Funktionen

        private void SpielerInListeHinzufügen()
        {
            //Spieler Name als String
            string spielerName = string.Empty;
            spielerName = SpielerEingabe_txtbx.Text;

            //Spieler zur SpielerListe hinzufügen
            SpielerListe_lstbx.Items.Add(spielerName);

            //Eingabefeld leeren
            SpielerEingabe_txtbx.Text = string.Empty;
        }

        private void SpielerListeLeeren()
        {
            //Alle Items der Spieler Liste entfernen
            SpielerListe_lstbx.Items.Clear();
        }


        //Events
        private void SpielerHinzufügen_btn_Click(object sender, EventArgs e)
        {
            SpielerInListeHinzufügen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SpielerListeLeeren();
        }

        private void Spiel_DerDümmsteFliegt_btn_Click(object sender, EventArgs e)
        {
            Form_DerDümmsteFliegt_Setup DerDümmsteFliegtSetup = new Form_DerDümmsteFliegt_Setup(SpielerListe_lstbx.Items.Count);
            DerDümmsteFliegtSetup.Show();
        }

        private void Spiel_Jeopardy_btn_Click(object sender, EventArgs e)
        {
            jeopardy Jeopardy = new jeopardy();
            Jeopardy.Show();
        }
    }
}
