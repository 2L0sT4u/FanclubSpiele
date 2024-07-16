namespace FanclubSpiele
{
    partial class Form_Spiele
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Spiel_DerDümmsteFliegt_btn = new System.Windows.Forms.Button();
            this.Spiel_Jeopardy_btn = new System.Windows.Forms.Button();
            this.SpielerEingabe_txtbx = new System.Windows.Forms.TextBox();
            this.SpielerListe_lstbx = new System.Windows.Forms.ListBox();
            this.SpielerHinzufügen_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Fragen_Jeopardy_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spiel_DerDümmsteFliegt_btn
            // 
            this.Spiel_DerDümmsteFliegt_btn.Location = new System.Drawing.Point(49, 38);
            this.Spiel_DerDümmsteFliegt_btn.Name = "Spiel_DerDümmsteFliegt_btn";
            this.Spiel_DerDümmsteFliegt_btn.Size = new System.Drawing.Size(644, 143);
            this.Spiel_DerDümmsteFliegt_btn.TabIndex = 0;
            this.Spiel_DerDümmsteFliegt_btn.Text = "DER DÜMMSTE FLIEGT";
            this.Spiel_DerDümmsteFliegt_btn.UseVisualStyleBackColor = true;
            this.Spiel_DerDümmsteFliegt_btn.Click += new System.EventHandler(this.Spiel_DerDümmsteFliegt_btn_Click);
            // 
            // Spiel_Jeopardy_btn
            // 
            this.Spiel_Jeopardy_btn.Location = new System.Drawing.Point(49, 319);
            this.Spiel_Jeopardy_btn.Name = "Spiel_Jeopardy_btn";
            this.Spiel_Jeopardy_btn.Size = new System.Drawing.Size(644, 143);
            this.Spiel_Jeopardy_btn.TabIndex = 1;
            this.Spiel_Jeopardy_btn.Text = "JEOPARDY";
            this.Spiel_Jeopardy_btn.UseVisualStyleBackColor = true;
            this.Spiel_Jeopardy_btn.Click += new System.EventHandler(this.Spiel_Jeopardy_btn_Click);
            // 
            // SpielerEingabe_txtbx
            // 
            this.SpielerEingabe_txtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SpielerEingabe_txtbx.Location = new System.Drawing.Point(810, 38);
            this.SpielerEingabe_txtbx.Name = "SpielerEingabe_txtbx";
            this.SpielerEingabe_txtbx.Size = new System.Drawing.Size(448, 49);
            this.SpielerEingabe_txtbx.TabIndex = 2;
            // 
            // SpielerListe_lstbx
            // 
            this.SpielerListe_lstbx.FormattingEnabled = true;
            this.SpielerListe_lstbx.ItemHeight = 42;
            this.SpielerListe_lstbx.Location = new System.Drawing.Point(810, 106);
            this.SpielerListe_lstbx.Name = "SpielerListe_lstbx";
            this.SpielerListe_lstbx.Size = new System.Drawing.Size(524, 382);
            this.SpielerListe_lstbx.TabIndex = 3;
            // 
            // SpielerHinzufügen_btn
            // 
            this.SpielerHinzufügen_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SpielerHinzufügen_btn.Location = new System.Drawing.Point(1275, 38);
            this.SpielerHinzufügen_btn.Name = "SpielerHinzufügen_btn";
            this.SpielerHinzufügen_btn.Size = new System.Drawing.Size(59, 49);
            this.SpielerHinzufügen_btn.TabIndex = 4;
            this.SpielerHinzufügen_btn.UseVisualStyleBackColor = false;
            this.SpielerHinzufügen_btn.Click += new System.EventHandler(this.SpielerHinzufügen_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(810, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(524, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fragen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Fragen_Jeopardy_btn
            // 
            this.Fragen_Jeopardy_btn.Location = new System.Drawing.Point(460, 492);
            this.Fragen_Jeopardy_btn.Name = "Fragen_Jeopardy_btn";
            this.Fragen_Jeopardy_btn.Size = new System.Drawing.Size(233, 50);
            this.Fragen_Jeopardy_btn.TabIndex = 7;
            this.Fragen_Jeopardy_btn.Text = "Fragen";
            this.Fragen_Jeopardy_btn.UseVisualStyleBackColor = true;
            this.Fragen_Jeopardy_btn.Click += new System.EventHandler(this.Fragen_Jeopardy_btn_Click);
            // 
            // Form_Spiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 573);
            this.Controls.Add(this.Fragen_Jeopardy_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SpielerHinzufügen_btn);
            this.Controls.Add(this.SpielerListe_lstbx);
            this.Controls.Add(this.SpielerEingabe_txtbx);
            this.Controls.Add(this.Spiel_Jeopardy_btn);
            this.Controls.Add(this.Spiel_DerDümmsteFliegt_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "Form_Spiele";
            this.Text = "Fanclub Spiele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Spiel_DerDümmsteFliegt_btn;
        private System.Windows.Forms.Button Spiel_Jeopardy_btn;
        private System.Windows.Forms.TextBox SpielerEingabe_txtbx;
        private System.Windows.Forms.ListBox SpielerListe_lstbx;
        private System.Windows.Forms.Button SpielerHinzufügen_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Fragen_Jeopardy_btn;
    }
}

