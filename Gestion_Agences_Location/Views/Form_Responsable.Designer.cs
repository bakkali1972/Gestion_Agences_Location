namespace Gestion_Agences_Location.Views
{
    partial class Form_Responsable
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
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.btnAjoutter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNomPrenomRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelephone_Responsable = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDRESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PRENOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVILLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNouveau.Location = new System.Drawing.Point(23, 417);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(425, 38);
            this.BtnNouveau.TabIndex = 53;
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
            this.BtnSupprimer.Location = new System.Drawing.Point(23, 597);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(425, 38);
            this.BtnSupprimer.TabIndex = 57;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // BtnModifier
            // 
            this.BtnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModifier.Location = new System.Drawing.Point(23, 551);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(425, 38);
            this.BtnModifier.TabIndex = 56;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRechercher.Location = new System.Drawing.Point(23, 505);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(425, 38);
            this.BtnRechercher.TabIndex = 55;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnAjoutter
            // 
            this.btnAjoutter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAjoutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjoutter.Location = new System.Drawing.Point(23, 460);
            this.btnAjoutter.Name = "btnAjoutter";
            this.btnAjoutter.Size = new System.Drawing.Size(425, 38);
            this.btnAjoutter.TabIndex = 54;
            this.btnAjoutter.Text = "Ajouter";
            this.btnAjoutter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 38);
            this.label2.TabIndex = 58;
            this.label2.Text = "RESPONSABLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNomPrenomRes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTelephone_Responsable);
            this.groupBox1.Location = new System.Drawing.Point(-16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 296);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nom";
            // 
            // TxtNomPrenomRes
            // 
            this.TxtNomPrenomRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPrenomRes.Location = new System.Drawing.Point(207, 31);
            this.TxtNomPrenomRes.Name = "TxtNomPrenomRes";
            this.TxtNomPrenomRes.Size = new System.Drawing.Size(330, 30);
            this.TxtNomPrenomRes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telephone";
            // 
            // TxtTelephone_Responsable
            // 
            this.TxtTelephone_Responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelephone_Responsable.Location = new System.Drawing.Point(207, 105);
            this.TxtTelephone_Responsable.Name = "TxtTelephone_Responsable";
            this.TxtTelephone_Responsable.Size = new System.Drawing.Size(330, 30);
            this.TxtTelephone_Responsable.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRESPONSABLE,
            this.NOM_PRENOM,
            this.TELE,
            this.IDVILLE});
            this.dataGridView1.Location = new System.Drawing.Point(565, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 687);
            this.dataGridView1.TabIndex = 60;
            // 
            // IDRESPONSABLE
            // 
            this.IDRESPONSABLE.DataPropertyName = "IDRESPONSABLE";
            this.IDRESPONSABLE.HeaderText = "IDRESPONSABLE";
            this.IDRESPONSABLE.Name = "IDRESPONSABLE";
            this.IDRESPONSABLE.Visible = false;
            // 
            // NOM_PRENOM
            // 
            this.NOM_PRENOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOM_PRENOM.DataPropertyName = "NOM_PRENOM";
            this.NOM_PRENOM.HeaderText = "NOM PRENOM";
            this.NOM_PRENOM.Name = "NOM_PRENOM";
            this.NOM_PRENOM.Visible = false;
            // 
            // TELE
            // 
            this.TELE.DataPropertyName = "TELE";
            this.TELE.HeaderText = "TELEPHONE";
            this.TELE.Name = "TELE";
            this.TELE.Visible = false;
            this.TELE.Width = 200;
            // 
            // IDVILLE
            // 
            this.IDVILLE.DataPropertyName = "IDVILLE";
            this.IDVILLE.HeaderText = "IDVILLE";
            this.IDVILLE.Name = "IDVILLE";
            this.IDVILLE.Visible = false;
            // 
            // Form_Responsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnNouveau);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.btnAjoutter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Responsable";
            this.Text = "Form_Responsable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.Button btnAjoutter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomPrenomRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTelephone_Responsable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PRENOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVILLE;
    }
}