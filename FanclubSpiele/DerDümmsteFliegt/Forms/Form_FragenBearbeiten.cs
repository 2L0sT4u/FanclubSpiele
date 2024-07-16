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
            bindingSource = new BindingSource();
            bindingSource.DataSource = fragen_ref;
            dataGridView1.DataSource = bindingSource;

        }
        List<DerDümmsteFliegt.Klassen.Aufgabe> fragen = new List<DerDümmsteFliegt.Klassen.Aufgabe>();

        
        //events
        private void hinzufügen_btn_Click(object sender, EventArgs e)
        {
            DerDümmsteFliegt.Klassen.Aufgabe aufgabe = new DerDümmsteFliegt.Klassen.Aufgabe(fragen.Count(), frage_txtbx.Text, antwort_txtbx.Text);
            ((List<DerDümmsteFliegt.Klassen.Aufgabe>)bindingSource.DataSource).Add(aufgabe);
            bindingSource.ResetBindings(false);
        }
    }
}
