namespace FanclubSpiele.DerDümmsteFliegt.Forms
{
    partial class Form_FragenBearbeiten
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
            this.frage_txtbx = new System.Windows.Forms.TextBox();
            this.antwort_txtbx = new System.Windows.Forms.TextBox();
            this.hinzufügen_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.laden_btn = new System.Windows.Forms.Button();
            this.speichern_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frage_txtbx
            // 
            this.frage_txtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.frage_txtbx.Location = new System.Drawing.Point(661, 12);
            this.frage_txtbx.Multiline = true;
            this.frage_txtbx.Name = "frage_txtbx";
            this.frage_txtbx.Size = new System.Drawing.Size(1091, 87);
            this.frage_txtbx.TabIndex = 1;
            this.frage_txtbx.Text = "Frage";
            // 
            // antwort_txtbx
            // 
            this.antwort_txtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.antwort_txtbx.Location = new System.Drawing.Point(661, 117);
            this.antwort_txtbx.Multiline = true;
            this.antwort_txtbx.Name = "antwort_txtbx";
            this.antwort_txtbx.Size = new System.Drawing.Size(1091, 77);
            this.antwort_txtbx.TabIndex = 2;
            this.antwort_txtbx.Text = "Antwort";
            // 
            // hinzufügen_btn
            // 
            this.hinzufügen_btn.Location = new System.Drawing.Point(661, 200);
            this.hinzufügen_btn.Name = "hinzufügen_btn";
            this.hinzufügen_btn.Size = new System.Drawing.Size(1091, 55);
            this.hinzufügen_btn.TabIndex = 3;
            this.hinzufügen_btn.Text = "hinzufügen";
            this.hinzufügen_btn.UseVisualStyleBackColor = true;
            this.hinzufügen_btn.Click += new System.EventHandler(this.hinzufügen_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(643, 810);
            this.listBox1.TabIndex = 4;
            // 
            // laden_btn
            // 
            this.laden_btn.Location = new System.Drawing.Point(661, 706);
            this.laden_btn.Name = "laden_btn";
            this.laden_btn.Size = new System.Drawing.Size(1091, 55);
            this.laden_btn.TabIndex = 5;
            this.laden_btn.Text = "laden";
            this.laden_btn.UseVisualStyleBackColor = true;
            this.laden_btn.Click += new System.EventHandler(this.laden_btn_Click);
            // 
            // speichern_btn
            // 
            this.speichern_btn.Location = new System.Drawing.Point(661, 767);
            this.speichern_btn.Name = "speichern_btn";
            this.speichern_btn.Size = new System.Drawing.Size(1091, 55);
            this.speichern_btn.TabIndex = 6;
            this.speichern_btn.Text = "speichern";
            this.speichern_btn.UseVisualStyleBackColor = true;
            this.speichern_btn.Click += new System.EventHandler(this.speichern_btn_Click);
            // 
            // Form_FragenBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 852);
            this.Controls.Add(this.speichern_btn);
            this.Controls.Add(this.laden_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hinzufügen_btn);
            this.Controls.Add(this.antwort_txtbx);
            this.Controls.Add(this.frage_txtbx);
            this.Name = "Form_FragenBearbeiten";
            this.Text = "Form_FragenBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox frage_txtbx;
        private System.Windows.Forms.TextBox antwort_txtbx;
        private System.Windows.Forms.Button hinzufügen_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button laden_btn;
        private System.Windows.Forms.Button speichern_btn;
    }
}