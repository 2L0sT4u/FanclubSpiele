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
        }

        private void CreateLabel(List<Player> players)
        {
            HashSet<int> Teamid = new HashSet<int>();
            for (int i = 0; i < players.Count; i++) { Teamid.Add(players[i].getTeamid()); }
            
            int index1 = 0; int index2 = 0;


            int startY = 50; // Startposition für die Labels
            int spacing = 35; // Abstand zwischen den Labels

            for (int i = 0; i < players.Count; i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();


                label.Text = players[i].getName();
                label.Location = new Point(50, startY + i * spacing); // Dynamische Positionierung
                label.AutoSize = true;
                label.Font = new Font("Arial", 20f);
                label.ForeColor = players[i].getColor();


                labels.Add(label);
                this.Controls.Add(label);

            }
        }
    }
}
