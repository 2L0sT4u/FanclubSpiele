using FanclubSpiele.DerDümmsteFliegt.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FanclubSpiele.DerDümmsteFliegt.Forms
{
    public partial class Form_FragenBearbeiten : Form
    {
        public Form_FragenBearbeiten(List<DerDümmsteFliegt.Klassen.Aufgabe> fragen_ref)
        {
            InitializeComponent();
            UpdateGrid(fragen_ref);
            getFragen(fragen_ref);

        }
        List<DerDümmsteFliegt.Klassen.Aufgabe> fragen = new List<DerDümmsteFliegt.Klassen.Aufgabe>();
        private void getFragen(List<DerDümmsteFliegt.Klassen.Aufgabe> fragen_ref)
        {
            fragen = fragen_ref;
        }

        private void UpdateGrid(List<DerDümmsteFliegt.Klassen.Aufgabe> fragen)
        {
            listBox1.Items.Clear();
            foreach (DerDümmsteFliegt.Klassen.Aufgabe aufgabe in fragen)
            {
                listBox1.Items.Add($"{aufgabe.id}: {aufgabe.frage} -> {aufgabe.antwort}");
            }
        }

        
        //events
        private void hinzufügen_btn_Click(object sender, EventArgs e)
        {
            DerDümmsteFliegt.Klassen.Aufgabe aufgabe = new DerDümmsteFliegt.Klassen.Aufgabe(fragen.Count(), frage_txtbx.Text, antwort_txtbx.Text);
            fragen.Add(aufgabe);
            UpdateGrid(fragen);
        }

        private void speichern_btn_Click(object sender, EventArgs e)
        {
            using (var stream = new FileStream("fragenDDF.xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Aufgabe>));
                ser.Serialize(stream, fragen);
            }
        }

        private void laden_btn_Click(object sender, EventArgs e)
        {
            var ser = new XmlSerializer(typeof(List<Aufgabe>));
            using (var reader = new StreamReader("fragenDDF.xml"))
            {
                fragen = (List<Aufgabe>)ser.Deserialize(reader);
            }
            UpdateGrid(fragen);
        }
    }
}
