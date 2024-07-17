using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele.Jeopardy
{
    public partial class FragenDatenBank : Form
    {

        public FragenDatenBank()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Fragebox.Text) || Fragebox.Text=="Frage" ||PunkteBox.Text=="Punkteanzahl"|| string.IsNullOrEmpty(GroupBox.Text) || GroupBox.Text == "Group" || string.IsNullOrEmpty(PunkteBox.Text)|| string.IsNullOrEmpty(AntwortBox.Text) || AntwortBox.Text == "Antwort")
            {
                Console.WriteLine("Fehler");
            }
            else
            {
                Fragen frage = new Fragen(Fragebox.Text, AntwortBox.Text, GroupBox.Text, Convert.ToInt16(PunkteBox.Text));
                DatenBank.Rows.Add(GroupBox.Text,Fragebox.Text,AntwortBox.Text,PunkteBox.Text);
                Fragen.FragenListe.Add(frage);
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
