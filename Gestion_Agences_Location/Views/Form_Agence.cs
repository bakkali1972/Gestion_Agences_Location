using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Agences_Location.Controllers;
using Gestion_Agences_Location.Models;

namespace Gestion_Agences_Location.Views
{
    public partial class Form_Agence : Form
    {
        public Form_Agence()
        {
            InitializeComponent();
        }
        int idAgence, index, id;
        Agence ag;

        private void Agence_Load(object sender, EventArgs e)
        {
           


            CmbVille.DataSource = new Controller_Ville().getAll();
            CmbVille.DisplayMember = "NOM";
            CmbVille.ValueMember = "IDVILLE";

            CmbResponsable.DataSource = new Controller_Responsable().getAll();
            CmbResponsable.DisplayMember = "NOM_PRENOM";
            CmbResponsable.ValueMember = "IDRESPONSABLE";

            BtnNouveau_Click(sender, e);


        }

       
        private void btnAjoutter_Click(object sender, EventArgs e)
        {
            Agence agence = new Agence()
            {
                NOM = TxtNom_Agence.Text,
                ADRESSE = TxtAdresse_Agence.Text,
                TELE = TxtTelephone_Agence.Text,
                IDVILLE = Convert.ToInt32(CmbVille.SelectedValue),
                IDRESPONSABLE = Convert.ToInt32(CmbResponsable.SelectedValue),
            };
            new Controller_Agence().Ajouter(agence);
            BtnNouveau_Click(sender, e);
        }


        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            
            TxtNom_Agence.Clear();
            TxtAdresse_Agence.Clear();
            TxtTelephone_Agence.Clear();
            CmbResponsable.Text = "";
            CmbVille.Text = "";
            TxtNom_Agence.Focus();
            dataGridView1.DataSource = new Controller_Agence().getAll();
        }

       
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            ag = new Controller_Agence().getByName(TxtNom_Agence.Text);
            remplirtextBoxCombo();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Agence agence = new Agence()
            {
                NOM = TxtNom_Agence.Text,
                ADRESSE = TxtAdresse_Agence.Text,
                TELE = TxtTelephone_Agence.Text,
                IDVILLE = Convert.ToInt32(CmbVille.SelectedValue),
                IDRESPONSABLE = Convert.ToInt32(CmbResponsable.SelectedValue),
            };
            new Controller_Agence().Modifier(agence);
            BtnNouveau_Click(sender, e);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                new Controller_Agence().Suprimer(idAgence);
                BtnNouveau_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            idAgence = Convert.ToInt32(dataGridView1.Rows[index].Cells["IDAGENCE2"].Value.ToString());
            ag = new Controller_Agence().getById(idAgence);
            remplirtextBoxCombo();
        }


        public void remplirtextBoxCombo()
        {
            TxtNom_Agence.Text= ag.NOM;
            TxtAdresse_Agence.Text= ag.ADRESSE;
            TxtTelephone_Agence.Text= ag.TELE;
            CmbVille.Text = ag.Ville.NOM;
            CmbResponsable.Text = ag.Responsable.NOM_PRENOM;
        }
    }
}
