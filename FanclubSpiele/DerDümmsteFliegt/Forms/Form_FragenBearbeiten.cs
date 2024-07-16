using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele.DerDümmsteFliegt.Forms
{
    public partial class Form_FragenBearbeiten : Form
    {
        private BindingSource bindingSource;

        public Form_FragenBearbeiten(List<DerDümmsteFliegt.Klassen.Aufgabe> fragen_ref)
        {
            InitializeComponent();
            dataGridView1.Columns["ID"].ValueType = typeof(Int32);
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
            dataGridView1.Rows.Clear();
            foreach (DerDümmsteFliegt.Klassen.Aufgabe aufgabe in fragen)
            {
                dataGridView1.Rows.Add();
                int rowIndex = dataGridView1.Rows.Count - 1;

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = aufgabe.id;
                dataGridView1.Rows[rowIndex].Cells["Frage"].Value = aufgabe.frage;
                dataGridView1.Rows[rowIndex].Cells["Antwort"].Value = aufgabe.antwort;
            }
        }

        
        //events
        private void hinzufügen_btn_Click(object sender, EventArgs e)
        {
            DerDümmsteFliegt.Klassen.Aufgabe aufgabe = new DerDümmsteFliegt.Klassen.Aufgabe(fragen.Count(), frage_txtbx.Text, antwort_txtbx.Text);
            fragen.Add(aufgabe);
            UpdateGrid(fragen);
        }
    }
}
