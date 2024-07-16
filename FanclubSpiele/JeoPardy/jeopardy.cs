using FanclubSpiele.JeoPardy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanclubSpiele.Jeopardy
{
    public partial class jeopardy : Form
    {
        List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();
        List<System.Windows.Forms.PictureBox> Farbenbox = new List<System.Windows.Forms.PictureBox>();

        public jeopardy()
        {
            InitializeComponent();
            CreateLabel(Team.TeamsList);
        }

        private void CreateLabel(List<Team> teams)
        {

            int startY = 50; // Startposition für die Labels
            int spacing = 35; // Abstand zwischen den Labels
            int i = 0;
            
            foreach (Team team in teams) {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                
                label.Name = team.p1.getName() + "," + team.p2.getName();
                label.Text =team.p1.getName()+","+team.p2.getName()+" "+team.getPoints().ToString();
                label.Location = new Point(50, startY + i * spacing); // Dynamische Positionierung
                label.AutoSize = true;
                label.Font = new Font("Arial", 20f);

                i++;
                labels.Add(label);
                this.Controls.Add(label);


            }
        }
    }
}
