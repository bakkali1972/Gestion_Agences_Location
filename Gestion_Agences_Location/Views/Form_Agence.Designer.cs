namespace Gestion_Agences_Location.Views
{
    partial class Form_Agence
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
            this.TxtTelephone_Agence = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbResponsable = new System.Windows.Forms.ComboBox();
            this.CmbVille = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNom_Agence = new System.Windows.Forms.TextBox();
            this.TxtAdresse_Agence = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.btnAjoutter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contratS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVILLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idagence2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagence2,
            this.nom,
            this.ADRESSE,
            this.TELE,
            this.IDVILLE,
            this.IDRESPONSABLE,
            this.Ville,
            this.Responsable,
            this.contratS});
            this.dataGridView1.Location = new System.Drawing.Point(439, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 560);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TxtTelephone_Agence
            // 
            this.TxtTelephone_Agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelephone_Agence.Location = new System.Drawing.Point(155, 116);
            this.TxtTelephone_Agence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelephone_Agence.Name = "TxtTelephone_Agence";
            this.TxtTelephone_Agence.Size = new System.Drawing.Size(248, 26);
            this.TxtTelephone_Agence.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbResponsable);
            this.groupBox1.Controls.Add(this.CmbVille);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNom_Agence);
            this.groupBox1.Controls.Add(this.TxtAdresse_Agence);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTelephone_Agence);
            this.groupBox1.Location = new System.Drawing.Point(4, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(419, 240);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // CmbResponsable
            // 
            this.CmbResponsable.FormattingEnabled = true;
            this.CmbResponsable.Location = new System.Drawing.Point(155, 202);
            this.CmbResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.CmbResponsable.Name = "CmbResponsable";
            this.CmbResponsable.Size = new System.Drawing.Size(248, 21);
            this.CmbResponsable.TabIndex = 37;
            // 
            // CmbVille
            // 
            this.CmbVille.FormattingEnabled = true;
            this.CmbVille.Location = new System.Drawing.Point(155, 156);
            this.CmbVille.Margin = new System.Windows.Forms.Padding(2);
            this.CmbVille.Name = "CmbVille";
            this.CmbVille.Size = new System.Drawing.Size(248, 21);
            this.CmbVille.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Responsable";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nom";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adresse";
            // 
            // TxtNom_Agence
            // 
            this.TxtNom_Agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom_Agence.Location = new System.Drawing.Point(155, 25);
            this.TxtNom_Agence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNom_Agence.Name = "TxtNom_Agence";
            this.TxtNom_Agence.Size = new System.Drawing.Size(248, 26);
            this.TxtNom_Agence.TabIndex = 0;
            // 
            // TxtAdresse_Agence
            // 
            this.TxtAdresse_Agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresse_Agence.Location = new System.Drawing.Point(155, 71);
            this.TxtAdresse_Agence.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAdresse_Agence.Name = "TxtAdresse_Agence";
            this.TxtAdresse_Agence.Size = new System.Drawing.Size(248, 26);
            this.TxtAdresse_Agence.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telephone";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNouveau.Location = new System.Drawing.Point(34, 345);
            this.BtnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(319, 31);
            this.BtnNouveau.TabIndex = 45;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSupprimer.Location = new System.Drawing.Point(34, 492);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(319, 31);
            this.BtnSupprimer.TabIndex = 49;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModifier.Location = new System.Drawing.Point(34, 454);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(319, 31);
            this.BtnModifier.TabIndex = 48;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRechercher.Location = new System.Drawing.Point(34, 417);
            this.BtnRechercher.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(319, 31);
            this.BtnRechercher.TabIndex = 47;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // btnAjoutter
            // 
            this.btnAjoutter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAjoutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjoutter.Location = new System.Drawing.Point(34, 380);
            this.btnAjoutter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutter.Name = "btnAjoutter";
            this.btnAjoutter.Size = new System.Drawing.Size(319, 31);
            this.btnAjoutter.TabIndex = 46;
            this.btnAjoutter.Text = "Ajouter";
            this.btnAjoutter.UseVisualStyleBackColor = true;
            this.btnAjoutter.Click += new System.EventHandler(this.btnAjoutter_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "AGENCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contratS
            // 
            this.contratS.DataPropertyName = "CONTRATs";
            this.contratS.HeaderText = "contratS";
            this.contratS.Name = "contratS";
            this.contratS.Visible = false;
            // 
            // Responsable
            // 
            this.Responsable.DataPropertyName = "Responsable";
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.Visible = false;
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.Visible = false;
            // 
            // IDRESPONSABLE
            // 
            this.IDRESPONSABLE.DataPropertyName = "IDRESPONSABLE";
            this.IDRESPONSABLE.HeaderText = "IDRESPONSABLE";
            this.IDRESPONSABLE.Name = "IDRESPONSABLE";
            this.IDRESPONSABLE.Visible = false;
            // 
            // IDVILLE
            // 
            this.IDVILLE.DataPropertyName = "IDVILLE";
            this.IDVILLE.HeaderText = "IDVILLE";
            this.IDVILLE.Name = "IDVILLE";
            this.IDVILLE.Visible = false;
            // 
            // TELE
            // 
            this.TELE.DataPropertyName = "TELE";
            this.TELE.HeaderText = "TELEPHONE";
            this.TELE.Name = "TELE";
            this.TELE.Width = 150;
            // 
            // ADRESSE
            // 
            this.ADRESSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADRESSE.DataPropertyName = "ADRESSE";
            this.ADRESSE.HeaderText = "ADRESSE";
            this.ADRESSE.Name = "ADRESSE";
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.DataPropertyName = "NOM";
            this.nom.HeaderText = "NOM";
            this.nom.Name = "nom";
            // 
            // idagence2
            // 
            this.idagence2.DataPropertyName = "IDAGENCE";
            this.idagence2.HeaderText = "IDAGENCE";
            this.idagence2.Name = "idagence2";
            this.idagence2.Visible = false;
            // 
            // Form_Agence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNouveau);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.btnAjoutter);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Agence";
            this.Text = "Agence";
            this.Load += new System.EventHandler(this.Agence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtTelephone_Agence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNom_Agence;
        private System.Windows.Forms.TextBox TxtAdresse_Agence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.Button btnAjoutter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbVille;
        private System.Windows.Forms.ComboBox CmbResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagence2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVILLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratS;
    }
}