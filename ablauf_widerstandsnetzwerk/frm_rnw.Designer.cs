
namespace ablauf_widerstandsnetzwerk
{
    partial class frm_rnw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rnw));
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.gb_eingabe = new System.Windows.Forms.GroupBox();
            this.tb_r1 = new System.Windows.Forms.TextBox();
            this.tb_r2 = new System.Windows.Forms.TextBox();
            this.lbl_r1 = new System.Windows.Forms.Label();
            this.lbl_r2 = new System.Windows.Forms.Label();
            this.rb_reihe = new System.Windows.Forms.RadioButton();
            this.rb_parallel = new System.Windows.Forms.RadioButton();
            this.gb_ausgabe = new System.Windows.Forms.GroupBox();
            this.lbl_gges = new System.Windows.Forms.Label();
            this.lbl_rges = new System.Windows.Forms.Label();
            this.tb_gges = new System.Windows.Forms.TextBox();
            this.tb_rges = new System.Windows.Forms.TextBox();
            this.btn_r1_uebernehmen = new System.Windows.Forms.Button();
            this.btn_beenden = new System.Windows.Forms.Button();
            this.gb_eingabe.SuspendLayout();
            this.gb_ausgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(74, 231);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(227, 23);
            this.btn_berechnen.TabIndex = 0;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // gb_eingabe
            // 
            this.gb_eingabe.Controls.Add(this.rb_parallel);
            this.gb_eingabe.Controls.Add(this.rb_reihe);
            this.gb_eingabe.Controls.Add(this.lbl_r2);
            this.gb_eingabe.Controls.Add(this.lbl_r1);
            this.gb_eingabe.Controls.Add(this.tb_r2);
            this.gb_eingabe.Controls.Add(this.tb_r1);
            this.gb_eingabe.Location = new System.Drawing.Point(74, 27);
            this.gb_eingabe.Name = "gb_eingabe";
            this.gb_eingabe.Size = new System.Drawing.Size(227, 183);
            this.gb_eingabe.TabIndex = 1;
            this.gb_eingabe.TabStop = false;
            this.gb_eingabe.Text = "Eingabe";
            // 
            // tb_r1
            // 
            this.tb_r1.Location = new System.Drawing.Point(135, 42);
            this.tb_r1.Name = "tb_r1";
            this.tb_r1.Size = new System.Drawing.Size(67, 20);
            this.tb_r1.TabIndex = 0;
            // 
            // tb_r2
            // 
            this.tb_r2.Location = new System.Drawing.Point(135, 68);
            this.tb_r2.Name = "tb_r2";
            this.tb_r2.Size = new System.Drawing.Size(67, 20);
            this.tb_r2.TabIndex = 1;
            // 
            // lbl_r1
            // 
            this.lbl_r1.AutoSize = true;
            this.lbl_r1.Location = new System.Drawing.Point(77, 45);
            this.lbl_r1.Name = "lbl_r1";
            this.lbl_r1.Size = new System.Drawing.Size(52, 13);
            this.lbl_r1.TabIndex = 2;
            this.lbl_r1.Text = "R1 [Ohm]";
            // 
            // lbl_r2
            // 
            this.lbl_r2.AutoSize = true;
            this.lbl_r2.Location = new System.Drawing.Point(77, 71);
            this.lbl_r2.Name = "lbl_r2";
            this.lbl_r2.Size = new System.Drawing.Size(52, 13);
            this.lbl_r2.TabIndex = 3;
            this.lbl_r2.Text = "R2 [Ohm]";
            // 
            // rb_reihe
            // 
            this.rb_reihe.AutoSize = true;
            this.rb_reihe.Location = new System.Drawing.Point(80, 113);
            this.rb_reihe.Name = "rb_reihe";
            this.rb_reihe.Size = new System.Drawing.Size(105, 17);
            this.rb_reihe.TabIndex = 4;
            this.rb_reihe.TabStop = true;
            this.rb_reihe.Text = "Reihenschaltung";
            this.rb_reihe.UseVisualStyleBackColor = true;
            // 
            // rb_parallel
            // 
            this.rb_parallel.AutoSize = true;
            this.rb_parallel.Location = new System.Drawing.Point(80, 136);
            this.rb_parallel.Name = "rb_parallel";
            this.rb_parallel.Size = new System.Drawing.Size(105, 17);
            this.rb_parallel.TabIndex = 5;
            this.rb_parallel.TabStop = true;
            this.rb_parallel.Text = "Parallelschaltung";
            this.rb_parallel.UseVisualStyleBackColor = true;
            // 
            // gb_ausgabe
            // 
            this.gb_ausgabe.Controls.Add(this.btn_r1_uebernehmen);
            this.gb_ausgabe.Controls.Add(this.lbl_gges);
            this.gb_ausgabe.Controls.Add(this.lbl_rges);
            this.gb_ausgabe.Controls.Add(this.tb_gges);
            this.gb_ausgabe.Controls.Add(this.tb_rges);
            this.gb_ausgabe.Location = new System.Drawing.Point(74, 275);
            this.gb_ausgabe.Name = "gb_ausgabe";
            this.gb_ausgabe.Size = new System.Drawing.Size(227, 149);
            this.gb_ausgabe.TabIndex = 2;
            this.gb_ausgabe.TabStop = false;
            this.gb_ausgabe.Text = "Ausgabe";
            // 
            // lbl_gges
            // 
            this.lbl_gges.Location = new System.Drawing.Point(28, 71);
            this.lbl_gges.Name = "lbl_gges";
            this.lbl_gges.Size = new System.Drawing.Size(101, 13);
            this.lbl_gges.TabIndex = 3;
            this.lbl_gges.Text = "Gges [Siemens]";
            this.lbl_gges.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_rges
            // 
            this.lbl_rges.Location = new System.Drawing.Point(31, 45);
            this.lbl_rges.Name = "lbl_rges";
            this.lbl_rges.Size = new System.Drawing.Size(98, 13);
            this.lbl_rges.TabIndex = 2;
            this.lbl_rges.Text = "Rges [Ohm]";
            this.lbl_rges.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_gges
            // 
            this.tb_gges.Location = new System.Drawing.Point(135, 68);
            this.tb_gges.Name = "tb_gges";
            this.tb_gges.Size = new System.Drawing.Size(67, 20);
            this.tb_gges.TabIndex = 1;
            // 
            // tb_rges
            // 
            this.tb_rges.Location = new System.Drawing.Point(135, 42);
            this.tb_rges.Name = "tb_rges";
            this.tb_rges.Size = new System.Drawing.Size(67, 20);
            this.tb_rges.TabIndex = 0;
            // 
            // btn_r1_uebernehmen
            // 
            this.btn_r1_uebernehmen.Location = new System.Drawing.Point(6, 106);
            this.btn_r1_uebernehmen.Name = "btn_r1_uebernehmen";
            this.btn_r1_uebernehmen.Size = new System.Drawing.Size(215, 23);
            this.btn_r1_uebernehmen.TabIndex = 3;
            this.btn_r1_uebernehmen.Text = "Rges als R1 übernehmen";
            this.btn_r1_uebernehmen.UseVisualStyleBackColor = true;
            this.btn_r1_uebernehmen.Click += new System.EventHandler(this.btn_r1_uebernehmen_Click);
            // 
            // btn_beenden
            // 
            this.btn_beenden.Location = new System.Drawing.Point(74, 440);
            this.btn_beenden.Name = "btn_beenden";
            this.btn_beenden.Size = new System.Drawing.Size(227, 23);
            this.btn_beenden.TabIndex = 3;
            this.btn_beenden.Text = "Beenden";
            this.btn_beenden.UseVisualStyleBackColor = true;
            this.btn_beenden.Click += new System.EventHandler(this.btn_beenden_Click);
            // 
            // frm_rnw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 509);
            this.Controls.Add(this.btn_beenden);
            this.Controls.Add(this.gb_ausgabe);
            this.Controls.Add(this.gb_eingabe);
            this.Controls.Add(this.btn_berechnen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_rnw";
            this.Text = "Widerstandsnetzwerke";
            this.Load += new System.EventHandler(this.frm_rnw_Load);
            this.gb_eingabe.ResumeLayout(false);
            this.gb_eingabe.PerformLayout();
            this.gb_ausgabe.ResumeLayout(false);
            this.gb_ausgabe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_berechnen;
        private System.Windows.Forms.GroupBox gb_eingabe;
        private System.Windows.Forms.RadioButton rb_parallel;
        private System.Windows.Forms.RadioButton rb_reihe;
        private System.Windows.Forms.Label lbl_r2;
        private System.Windows.Forms.Label lbl_r1;
        private System.Windows.Forms.TextBox tb_r2;
        private System.Windows.Forms.TextBox tb_r1;
        private System.Windows.Forms.GroupBox gb_ausgabe;
        private System.Windows.Forms.Button btn_r1_uebernehmen;
        private System.Windows.Forms.Label lbl_gges;
        private System.Windows.Forms.Label lbl_rges;
        private System.Windows.Forms.TextBox tb_gges;
        private System.Windows.Forms.TextBox tb_rges;
        private System.Windows.Forms.Button btn_beenden;
    }
}

