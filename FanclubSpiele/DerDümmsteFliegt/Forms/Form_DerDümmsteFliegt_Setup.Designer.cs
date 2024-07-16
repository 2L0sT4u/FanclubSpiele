namespace FanclubSpiele
{
    partial class Form_DerDümmsteFliegt_Setup
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
            this.label1 = new System.Windows.Forms.Label();
            this.SpielerLeben_nmupdwn = new System.Windows.Forms.NumericUpDown();
            this.EmpfFragen_lbl = new System.Windows.Forms.Label();
            this.rundenZeit_nmupdwn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FragenBearbeiten_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpielerLeben_nmupdwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rundenZeit_nmupdwn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leben pro Spieler:";
            // 
            // SpielerLeben_nmupdwn
            // 
            this.SpielerLeben_nmupdwn.Location = new System.Drawing.Point(359, 7);
            this.SpielerLeben_nmupdwn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.SpielerLeben_nmupdwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpielerLeben_nmupdwn.Name = "SpielerLeben_nmupdwn";
            this.SpielerLeben_nmupdwn.Size = new System.Drawing.Size(46, 49);
            this.SpielerLeben_nmupdwn.TabIndex = 1;
            this.SpielerLeben_nmupdwn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SpielerLeben_nmupdwn.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // EmpfFragen_lbl
            // 
            this.EmpfFragen_lbl.AutoSize = true;
            this.EmpfFragen_lbl.Location = new System.Drawing.Point(12, 234);
            this.EmpfFragen_lbl.Name = "EmpfFragen_lbl";
            this.EmpfFragen_lbl.Size = new System.Drawing.Size(507, 42);
            this.EmpfFragen_lbl.TabIndex = 2;
            this.EmpfFragen_lbl.Text = "(min xxx Fragen empfohlen)";
            // 
            // rundenZeit_nmupdwn
            // 
            this.rundenZeit_nmupdwn.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rundenZeit_nmupdwn.Location = new System.Drawing.Point(308, 72);
            this.rundenZeit_nmupdwn.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.rundenZeit_nmupdwn.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.rundenZeit_nmupdwn.Name = "rundenZeit_nmupdwn";
            this.rundenZeit_nmupdwn.Size = new System.Drawing.Size(97, 49);
            this.rundenZeit_nmupdwn.TabIndex = 4;
            this.rundenZeit_nmupdwn.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.rundenZeit_nmupdwn.ValueChanged += new System.EventHandler(this.rundenZeit_nmupdwn_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zeit pro Runde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anzahl Fragen: xxx";
            // 
            // FragenBearbeiten_btn
            // 
            this.FragenBearbeiten_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FragenBearbeiten_btn.Location = new System.Drawing.Point(19, 296);
            this.FragenBearbeiten_btn.Name = "FragenBearbeiten_btn";
            this.FragenBearbeiten_btn.Size = new System.Drawing.Size(386, 64);
            this.FragenBearbeiten_btn.TabIndex = 6;
            this.FragenBearbeiten_btn.Text = "Fragen bearbeiten";
            this.FragenBearbeiten_btn.UseVisualStyleBackColor = false;
            this.FragenBearbeiten_btn.Click += new System.EventHandler(this.FragenBearbeiten_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(19, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 105);
            this.button2.TabIndex = 7;
            this.button2.Text = "Spiel starten ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form_DerDümmsteFliegt_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FragenBearbeiten_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rundenZeit_nmupdwn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpfFragen_lbl);
            this.Controls.Add(this.SpielerLeben_nmupdwn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "Form_DerDümmsteFliegt_Setup";
            this.Text = "DerDümmsteFliegt_Setup";
            ((System.ComponentModel.ISupportInitialize)(this.SpielerLeben_nmupdwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rundenZeit_nmupdwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpielerLeben_nmupdwn;
        private System.Windows.Forms.Label EmpfFragen_lbl;
        private System.Windows.Forms.NumericUpDown rundenZeit_nmupdwn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FragenBearbeiten_btn;
        private System.Windows.Forms.Button button2;
    }
}