namespace ex4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Dat_Nais = new System.Windows.Forms.DateTimePicker();
            this.Txt_Pre = new System.Windows.Forms.TextBox();
            this.rad_Ouv = new System.Windows.Forms.RadioButton();
            this.Btn_Ajo = new System.Windows.Forms.Button();
            this.grp_ca = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rad_1 = new System.Windows.Forms.RadioButton();
            this.rad_2 = new System.Windows.Forms.RadioButton();
            this.rad_4 = new System.Windows.Forms.RadioButton();
            this.rad_3 = new System.Windows.Forms.RadioButton();
            this.Txt_Mat = new System.Windows.Forms.TextBox();
            this.grp_ou = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dat_Ent = new System.Windows.Forms.DateTimePicker();
            this.grp_pt = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Ca = new System.Windows.Forms.TextBox();
            this.Txt_Perc = new System.Windows.Forms.TextBox();
            this.rad_Pat = new System.Windows.Forms.RadioButton();
            this.rad_Cad = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DGV_EM = new System.Windows.Forms.DataGridView();
            this.MAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATNAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grp_ca.SuspendLayout();
            this.grp_ou.SuspendLayout();
            this.grp_pt.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Nom);
            this.groupBox1.Controls.Add(this.Dat_Nais);
            this.groupBox1.Controls.Add(this.Txt_Pre);
            this.groupBox1.Controls.Add(this.rad_Ouv);
            this.groupBox1.Controls.Add(this.Btn_Ajo);
            this.groupBox1.Controls.Add(this.grp_ca);
            this.groupBox1.Controls.Add(this.Txt_Mat);
            this.groupBox1.Controls.Add(this.grp_ou);
            this.groupBox1.Controls.Add(this.grp_pt);
            this.groupBox1.Controls.Add(this.rad_Pat);
            this.groupBox1.Controls.Add(this.rad_Cad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employe";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date de \r\nNaissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Matricule";
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(86, 130);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(127, 20);
            this.Txt_Nom.TabIndex = 4;
            // 
            // Dat_Nais
            // 
            this.Dat_Nais.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Nais.Location = new System.Drawing.Point(89, 221);
            this.Dat_Nais.Name = "Dat_Nais";
            this.Dat_Nais.Size = new System.Drawing.Size(124, 20);
            this.Dat_Nais.TabIndex = 7;
            this.Dat_Nais.Value = new System.DateTime(2022, 12, 4, 16, 32, 50, 0);
            // 
            // Txt_Pre
            // 
            this.Txt_Pre.Location = new System.Drawing.Point(86, 185);
            this.Txt_Pre.Name = "Txt_Pre";
            this.Txt_Pre.Size = new System.Drawing.Size(127, 20);
            this.Txt_Pre.TabIndex = 1;
            // 
            // rad_Ouv
            // 
            this.rad_Ouv.AutoSize = true;
            this.rad_Ouv.Location = new System.Drawing.Point(671, 19);
            this.rad_Ouv.Name = "rad_Ouv";
            this.rad_Ouv.Size = new System.Drawing.Size(59, 17);
            this.rad_Ouv.TabIndex = 6;
            this.rad_Ouv.Text = "Ouvrier";
            this.rad_Ouv.UseVisualStyleBackColor = true;
            this.rad_Ouv.CheckedChanged += new System.EventHandler(this.rad_Ouv_CheckedChanged);
            // 
            // Btn_Ajo
            // 
            this.Btn_Ajo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Ajo.Location = new System.Drawing.Point(650, 179);
            this.Btn_Ajo.Name = "Btn_Ajo";
            this.Btn_Ajo.Size = new System.Drawing.Size(161, 75);
            this.Btn_Ajo.TabIndex = 3;
            this.Btn_Ajo.Text = "Ajouter";
            this.Btn_Ajo.UseVisualStyleBackColor = true;
            this.Btn_Ajo.Click += new System.EventHandler(this.Btn_Ajo_Click);
            // 
            // grp_ca
            // 
            this.grp_ca.Controls.Add(this.label7);
            this.grp_ca.Controls.Add(this.rad_1);
            this.grp_ca.Controls.Add(this.rad_2);
            this.grp_ca.Controls.Add(this.rad_4);
            this.grp_ca.Controls.Add(this.rad_3);
            this.grp_ca.Location = new System.Drawing.Point(424, 58);
            this.grp_ca.Name = "grp_ca";
            this.grp_ca.Size = new System.Drawing.Size(199, 212);
            this.grp_ca.TabIndex = 2;
            this.grp_ca.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Indice :";
            // 
            // rad_1
            // 
            this.rad_1.AutoSize = true;
            this.rad_1.Location = new System.Drawing.Point(47, 50);
            this.rad_1.Name = "rad_1";
            this.rad_1.Size = new System.Drawing.Size(31, 17);
            this.rad_1.TabIndex = 5;
            this.rad_1.TabStop = true;
            this.rad_1.Text = "1";
            this.rad_1.UseVisualStyleBackColor = true;
            // 
            // rad_2
            // 
            this.rad_2.AutoSize = true;
            this.rad_2.Location = new System.Drawing.Point(47, 92);
            this.rad_2.Name = "rad_2";
            this.rad_2.Size = new System.Drawing.Size(31, 17);
            this.rad_2.TabIndex = 4;
            this.rad_2.TabStop = true;
            this.rad_2.Text = "2";
            this.rad_2.UseVisualStyleBackColor = true;
            // 
            // rad_4
            // 
            this.rad_4.AutoSize = true;
            this.rad_4.Location = new System.Drawing.Point(47, 167);
            this.rad_4.Name = "rad_4";
            this.rad_4.Size = new System.Drawing.Size(31, 17);
            this.rad_4.TabIndex = 3;
            this.rad_4.TabStop = true;
            this.rad_4.Text = "4";
            this.rad_4.UseVisualStyleBackColor = true;
            // 
            // rad_3
            // 
            this.rad_3.AutoSize = true;
            this.rad_3.Location = new System.Drawing.Point(47, 130);
            this.rad_3.Name = "rad_3";
            this.rad_3.Size = new System.Drawing.Size(31, 17);
            this.rad_3.TabIndex = 2;
            this.rad_3.TabStop = true;
            this.rad_3.Text = "3";
            this.rad_3.UseVisualStyleBackColor = true;
            // 
            // Txt_Mat
            // 
            this.Txt_Mat.Location = new System.Drawing.Point(86, 71);
            this.Txt_Mat.Name = "Txt_Mat";
            this.Txt_Mat.Size = new System.Drawing.Size(127, 20);
            this.Txt_Mat.TabIndex = 0;
            // 
            // grp_ou
            // 
            this.grp_ou.Controls.Add(this.label6);
            this.grp_ou.Controls.Add(this.dat_Ent);
            this.grp_ou.Location = new System.Drawing.Point(629, 58);
            this.grp_ou.Name = "grp_ou";
            this.grp_ou.Size = new System.Drawing.Size(182, 109);
            this.grp_ou.TabIndex = 2;
            this.grp_ou.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date d\'entree :";
            // 
            // dat_Ent
            // 
            this.dat_Ent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_Ent.Location = new System.Drawing.Point(21, 68);
            this.dat_Ent.Name = "dat_Ent";
            this.dat_Ent.Size = new System.Drawing.Size(123, 20);
            this.dat_Ent.TabIndex = 8;
            // 
            // grp_pt
            // 
            this.grp_pt.Controls.Add(this.label3);
            this.grp_pt.Controls.Add(this.label2);
            this.grp_pt.Controls.Add(this.Txt_Ca);
            this.grp_pt.Controls.Add(this.Txt_Perc);
            this.grp_pt.Location = new System.Drawing.Point(219, 58);
            this.grp_pt.Name = "grp_pt";
            this.grp_pt.Size = new System.Drawing.Size(199, 206);
            this.grp_pt.TabIndex = 2;
            this.grp_pt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pourcentage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chiffre d\'affaire :";
            // 
            // Txt_Ca
            // 
            this.Txt_Ca.Location = new System.Drawing.Point(27, 50);
            this.Txt_Ca.Name = "Txt_Ca";
            this.Txt_Ca.Size = new System.Drawing.Size(146, 20);
            this.Txt_Ca.TabIndex = 3;
            // 
            // Txt_Perc
            // 
            this.Txt_Perc.Location = new System.Drawing.Point(27, 149);
            this.Txt_Perc.Name = "Txt_Perc";
            this.Txt_Perc.Size = new System.Drawing.Size(146, 20);
            this.Txt_Perc.TabIndex = 2;
            // 
            // rad_Pat
            // 
            this.rad_Pat.AutoSize = true;
            this.rad_Pat.Location = new System.Drawing.Point(266, 19);
            this.rad_Pat.Name = "rad_Pat";
            this.rad_Pat.Size = new System.Drawing.Size(56, 17);
            this.rad_Pat.TabIndex = 0;
            this.rad_Pat.TabStop = true;
            this.rad_Pat.Text = "Patron";
            this.rad_Pat.UseVisualStyleBackColor = true;
            this.rad_Pat.CheckedChanged += new System.EventHandler(this.Rad_Pat_CheckedChanged);
            // 
            // rad_Cad
            // 
            this.rad_Cad.AutoSize = true;
            this.rad_Cad.Location = new System.Drawing.Point(471, 19);
            this.rad_Cad.Name = "rad_Cad";
            this.rad_Cad.Size = new System.Drawing.Size(53, 17);
            this.rad_Cad.TabIndex = 1;
            this.rad_Cad.TabStop = true;
            this.rad_Cad.Text = "Cadre";
            this.rad_Cad.UseVisualStyleBackColor = true;
            this.rad_Cad.CheckedChanged += new System.EventHandler(this.Rad_Cad_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DGV_EM);
            this.groupBox5.Location = new System.Drawing.Point(12, 297);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(824, 293);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste des Employes";
            // 
            // DGV_EM
            // 
            this.DGV_EM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAT,
            this.NOM,
            this.PREN,
            this.DATNAIS,
            this.SAL});
            this.DGV_EM.Location = new System.Drawing.Point(6, 19);
            this.DGV_EM.Name = "DGV_EM";
            this.DGV_EM.Size = new System.Drawing.Size(805, 268);
            this.DGV_EM.TabIndex = 0;
            // 
            // MAT
            // 
            this.MAT.HeaderText = "Matricule";
            this.MAT.Name = "MAT";
            // 
            // NOM
            // 
            this.NOM.HeaderText = "Nom";
            this.NOM.Name = "NOM";
            // 
            // PREN
            // 
            this.PREN.HeaderText = "Prenom";
            this.PREN.Name = "PREN";
            // 
            // DATNAIS
            // 
            this.DATNAIS.HeaderText = "Date de naissance";
            this.DATNAIS.Name = "DATNAIS";
            // 
            // SAL
            // 
            this.SAL.HeaderText = "Salaire";
            this.SAL.Name = "SAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 595);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion des Employes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_ca.ResumeLayout(false);
            this.grp_ca.PerformLayout();
            this.grp_ou.ResumeLayout(false);
            this.grp_ou.PerformLayout();
            this.grp_pt.ResumeLayout(false);
            this.grp_pt.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_ca;
        private System.Windows.Forms.GroupBox grp_ou;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DGV_EM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.DateTimePicker Dat_Nais;
        private System.Windows.Forms.TextBox Txt_Pre;
        private System.Windows.Forms.RadioButton rad_Ouv;
        private System.Windows.Forms.Button Btn_Ajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad_1;
        private System.Windows.Forms.RadioButton rad_2;
        private System.Windows.Forms.RadioButton rad_4;
        private System.Windows.Forms.RadioButton rad_3;
        private System.Windows.Forms.TextBox Txt_Mat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dat_Ent;
        private System.Windows.Forms.RadioButton rad_Pat;
        private System.Windows.Forms.RadioButton rad_Cad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grp_pt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Ca;
        private System.Windows.Forms.TextBox Txt_Perc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATNAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAL;
    }
}

