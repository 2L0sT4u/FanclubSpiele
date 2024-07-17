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
using System.Runtime.Serialization.Formatters.Binary;

namespace FanclubSpiele.Jeopardy
{

    public partial class FragenDatenBank : Form
    {

        class DataSerializer
        {
            public List<Fragen> FragenListe = new List<Fragen>();

            public void XmlSerialize(Type dataType, object data, string filePath)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(dataType);
                if (File.Exists(filePath)) File.Delete(filePath);
                TextWriter writer = new StreamWriter(filePath);
                xmlSerializer.Serialize(writer, data);
                writer.Close();
            }

            public object XmlDeserialize(Type dataType, string filePath)
            {
                object obj = null;

                XmlSerializer xmlSerializer = new XmlSerializer(dataType);
                if (File.Exists(filePath))
                {
                    TextReader textReader = new StreamReader(filePath);
                    obj = xmlSerializer.Deserialize(textReader);
                    textReader.Close();
                }
                return obj;
            }

        }

        public FragenDatenBank()
        {
            InitializeComponent();
        }

        DataSerializer serializer = new DataSerializer();
        string filePath = "Fragen.save";

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Fragebox.Text) || Fragebox.Text=="Frage" ||PunkteBox.Text=="Punkteanzahl"|| string.IsNullOrEmpty(GroupBox.Text) || GroupBox.Text == "Group" || string.IsNullOrEmpty(PunkteBox.Text)|| string.IsNullOrEmpty(AntwortBox.Text) || AntwortBox.Text == "Antwort")
            {
                Console.WriteLine("Fehler");
            }
            else
            {
                Fragen frage = new Fragen(Fragebox.Text, AntwortBox.Text, GroupBox.Text, Convert.ToInt16(PunkteBox.Text));
                DatenBank.Rows.Add(GroupBox.Text,Fragebox.Text,AntwortBox.Text,Convert.ToInt16(PunkteBox.Text));
                serializer.FragenListe.Add(frage);
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializer.XmlSerialize(typeof(List<Fragen>),serializer.FragenListe,filePath);
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deserializedData = serializer.XmlDeserialize(typeof(List<Fragen>), filePath) as List<Fragen>;
            if (deserializedData != null)
            {
                serializer.FragenListe = deserializedData;
                DatenBank.Rows.Clear();
                foreach (var frage in serializer.FragenListe)
                {
                    DatenBank.Rows.Add(frage.getGroup(), frage.getFrage(), frage.getAntwort(), frage.getReward());
                }
            }


        }

        
    }
    
}
