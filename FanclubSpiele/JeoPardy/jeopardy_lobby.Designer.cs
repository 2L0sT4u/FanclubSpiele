namespace FanclubSpiele.Jeopardy
{
    partial class jeopardy_lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zufall_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zufall_btn
            // 
            this.Zufall_btn.Location = new System.Drawing.Point(717, 156);
            this.Zufall_btn.Name = "Zufall_btn";
            this.Zufall_btn.Size = new System.Drawing.Size(95, 48);
            this.Zufall_btn.TabIndex = 0;
            this.Zufall_btn.Text = "Zufällig";
            this.Zufall_btn.UseVisualStyleBackColor = true;
            this.Zufall_btn.Click += new System.EventHandler(this.Zufall_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(717, 102);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(95, 48);
            this.Reset_btn.TabIndex = 1;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(717, 48);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(95, 48);
            this.Play_btn.TabIndex = 2;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team Auswahl";
            // 
            // jeopardy_lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Zufall_btn);
            this.Name = "jeopardy_lobby";
            this.Text = "Jeopardy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zufall_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Label label1;
    }
}