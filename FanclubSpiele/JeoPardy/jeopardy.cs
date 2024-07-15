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

        public jeopardy()
        {
            InitializeComponent();
            
        }
        
        private void CreateLabel(List<Player> players)
        {
            int startY = 50; // Startposition für die Labels
            int spacing = 0; // Abstand zwischen den Labels

            Console.WriteLine(players.Count);
            for (int i = 0; i < players.Count; i++) {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                this.Controls.Add(label);
                
                label.Name = players[i].getName();
                label.Text = players[i].getName();
                label.Location = new Point(50, startY + i * spacing); // Dynamische Positionierung
                label.AutoSize = true;
                label.Font = new Font("Arial", 10f);
                label.ForeColor = Color.Black;
                label.Visible = true;

                
                labels.Add(label);
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateLabel(Team.PlayerList);
        }
    }
}
