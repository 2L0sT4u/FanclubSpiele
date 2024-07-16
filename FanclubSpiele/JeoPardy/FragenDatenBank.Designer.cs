namespace FanclubSpiele.Jeopardy
{
    partial class FragenDatenBank
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
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntwortBox = new System.Windows.Forms.RichTextBox();
            this.Fragebox = new System.Windows.Forms.RichTextBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.PunkteBox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Frage,
            this.Antwort,
            this.Points});
            this.dataGridView1.Location = new System.Drawing.Point(43, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            // 
            // Frage
            // 
            this.Frage.HeaderText = "Frage";
            this.Frage.Name = "Frage";
            // 
            // Antwort
            // 
            this.Antwort.HeaderText = "Antwort";
            this.Antwort.Name = "Antwort";
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            // 
            // AntwortBox
            // 
            this.AntwortBox.Location = new System.Drawing.Point(296, 466);
            this.AntwortBox.Name = "AntwortBox";
            this.AntwortBox.Size = new System.Drawing.Size(232, 38);
            this.AntwortBox.TabIndex = 1;
            this.AntwortBox.Text = "Antwort";
            // 
            // Fragebox
            // 
            this.Fragebox.Location = new System.Drawing.Point(296, 422);
            this.Fragebox.Name = "Fragebox";
            this.Fragebox.Size = new System.Drawing.Size(232, 38);
            this.Fragebox.TabIndex = 3;
            this.Fragebox.Text = "Frage";
            // 
            // GroupBox
            // 
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Items.AddRange(new object[] {
            "Spiele",
            "Werbesprüche",
            "Sprichworte"});
            this.GroupBox.Location = new System.Drawing.Point(122, 451);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(121, 21);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.Text = "Group";
            // 
            // PunkteBox
            // 
            this.PunkteBox.FormattingEnabled = true;
            this.PunkteBox.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.PunkteBox.Location = new System.Drawing.Point(549, 451);
            this.PunkteBox.Name = "PunkteBox";
            this.PunkteBox.Size = new System.Drawing.Size(121, 21);
            this.PunkteBox.TabIndex = 5;
            this.PunkteBox.Text = "Punkteanzahl";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(713, 449);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Hinzufügen";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // FragenDatenBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 540);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.PunkteBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Fragebox);
            this.Controls.Add(this.AntwortBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FragenDatenBank";
            this.Text = "FragenDatenBank";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.RichTextBox AntwortBox;
        private System.Windows.Forms.RichTextBox Fragebox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.ComboBox PunkteBox;
        private System.Windows.Forms.Button add_btn;
    }
}