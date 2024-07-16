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
            int startX = 200;
            int startY = 50; // Startposition für die Labels
            int spacing = 35; // Abstand zwischen den Labels
            int i = 0;
            int fontsize = 20;
            
            foreach (Team team in teams) {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();

                
                label.Name = team.p1.getName() + "," + team.p2.getName();
                label.Text =team.p1.getName()+","+team.p2.getName()+" "+team.getPoints().ToString();
                label.Location = new Point(startX, startY + i * spacing); // Dynamische Positionierung
                label.AutoSize = true;
                label.Font = new Font("Arial", (float)fontsize);
                
                pictureBox.BackColor = team.p1.getColor();
                pictureBox.Size = new System.Drawing.Size(10, 10);
                pictureBox.Location = new Point(startX-10,startY + i * spacing+(int)(fontsize/2));

                i++;
                labels.Add(label);
                Farbenbox.Add(pictureBox);
                this.Controls.Add(label);
                this.Controls.Add(pictureBox);


            }
        }
    }
}
