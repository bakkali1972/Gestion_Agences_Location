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
        Ville ville2;
        Responsable responsable2;
       
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
            dataGridView1.DataSource = new Controller_Agence().getAll();
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
            dataGridView1.DataSource = new Controller_Agence().getByName(TxtNom_Agence.Text);
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
            TxtNom_Agence.Text= dataGridView1.Rows[index].Cells["NOM"].Value.ToString();
            TxtAdresse_Agence.Text= dataGridView1.Rows[index].Cells["ADRESSE"].Value.ToString();
            TxtTelephone_Agence.Text= dataGridView1.Rows[index].Cells["TELE"].Value.ToString();

            // Remplisssage ville name
            id =Convert.ToInt32(dataGridView1.Rows[index].Cells["idville"].Value.ToString());
            ville2 = new Controller_Ville().getById(id);
            CmbVille.Text = ville2.NOM;


            //Remplissage Responsable Name
            id = Convert.ToInt32(dataGridView1.Rows[index].Cells["idresponsable"].Value.ToString());
            responsable2 = new Controller_Responsable().getByIdResponsable(id);
            CmbResponsable.Text = responsable2.NOM_PRENOM;



        }
    }
}
