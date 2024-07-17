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
            this.DatenBank = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntwortBox = new System.Windows.Forms.RichTextBox();
            this.Fragebox = new System.Windows.Forms.RichTextBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.PunkteBox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DatenBank)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatenBank
            // 
            this.DatenBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatenBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Frage,
            this.Antwort,
            this.Points});
            this.DatenBank.Location = new System.Drawing.Point(43, 30);
            this.DatenBank.Name = "DatenBank";
            this.DatenBank.Size = new System.Drawing.Size(745, 372);
            this.DatenBank.TabIndex = 0;
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
            this.AntwortBox.Location = new System.Drawing.Point(451, 434);
            this.AntwortBox.Name = "AntwortBox";
            this.AntwortBox.Size = new System.Drawing.Size(232, 38);
            this.AntwortBox.TabIndex = 1;
            this.AntwortBox.Text = "";
            // 
            // Fragebox
            // 
            this.Fragebox.Location = new System.Drawing.Point(210, 435);
            this.Fragebox.Name = "Fragebox";
            this.Fragebox.Size = new System.Drawing.Size(232, 38);
            this.Fragebox.TabIndex = 3;
            this.Fragebox.Text = "";
            // 
            // GroupBox
            // 
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Items.AddRange(new object[] {
            "Spiele",
            "Werbesprüche",
            "Sprichworte"});
            this.GroupBox.Location = new System.Drawing.Point(43, 419);
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
            this.PunkteBox.Location = new System.Drawing.Point(43, 452);
            this.PunkteBox.Name = "PunkteBox";
            this.PunkteBox.Size = new System.Drawing.Size(121, 21);
            this.PunkteBox.TabIndex = 5;
            this.PunkteBox.Text = "Punkteanzahl";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(689, 435);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Hinzufügen";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Antwort:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // FragenDatenBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.PunkteBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Fragebox);
            this.Controls.Add(this.AntwortBox);
            this.Controls.Add(this.DatenBank);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FragenDatenBank";
            this.Text = "FragenDatenBank";
            ((System.ComponentModel.ISupportInitialize)(this.DatenBank)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatenBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antwort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.RichTextBox AntwortBox;
        private System.Windows.Forms.RichTextBox Fragebox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.ComboBox PunkteBox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
    }
}