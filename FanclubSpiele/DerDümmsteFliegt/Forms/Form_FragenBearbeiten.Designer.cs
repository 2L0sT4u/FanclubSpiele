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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frage_txtbx = new System.Windows.Forms.TextBox();
            this.antwort_txtbx = new System.Windows.Forms.TextBox();
            this.hinzufügen_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Frage,
            this.Antwort});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1814, 813);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Frage
            // 
            this.Frage.HeaderText = "Frage";
            this.Frage.Name = "Frage";
            this.Frage.ReadOnly = true;
            // 
            // Antwort
            // 
            this.Antwort.HeaderText = "Antwort";
            this.Antwort.Name = "Antwort";
            this.Antwort.ReadOnly = true;
            // 
            // frage_txtbx
            // 
            this.frage_txtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.frage_txtbx.Location = new System.Drawing.Point(12, 819);
            this.frage_txtbx.Name = "frage_txtbx";
            this.frage_txtbx.Size = new System.Drawing.Size(1790, 20);
            this.frage_txtbx.TabIndex = 1;
            this.frage_txtbx.Text = "Frage";
            // 
            // antwort_txtbx
            // 
            this.antwort_txtbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.antwort_txtbx.Location = new System.Drawing.Point(12, 845);
            this.antwort_txtbx.Name = "antwort_txtbx";
            this.antwort_txtbx.Size = new System.Drawing.Size(1790, 20);
            this.antwort_txtbx.TabIndex = 2;
            this.antwort_txtbx.Text = "Antwort";
            // 
            // hinzufügen_btn
            // 
            this.hinzufügen_btn.Location = new System.Drawing.Point(12, 872);
            this.hinzufügen_btn.Name = "hinzufügen_btn";
            this.hinzufügen_btn.Size = new System.Drawing.Size(1790, 28);
            this.hinzufügen_btn.TabIndex = 3;
            this.hinzufügen_btn.Text = "hinzufügen";
            this.hinzufügen_btn.UseVisualStyleBackColor = true;
            this.hinzufügen_btn.Click += new System.EventHandler(this.hinzufügen_btn_Click);
            // 
            // Form_FragenBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 912);
            this.Controls.Add(this.hinzufügen_btn);
            this.Controls.Add(this.antwort_txtbx);
            this.Controls.Add(this.frage_txtbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_FragenBearbeiten";
            this.Text = "Form_FragenBearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort;
        private System.Windows.Forms.TextBox frage_txtbx;
        private System.Windows.Forms.TextBox antwort_txtbx;
        private System.Windows.Forms.Button hinzufügen_btn;
    }
}