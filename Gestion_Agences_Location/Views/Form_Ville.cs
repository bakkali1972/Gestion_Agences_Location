using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Agences_Location.Models;
using Gestion_Agences_Location.Controllers;


namespace Gestion_Agences_Location.Views
{
    public partial class Form_Ville : Form
    {
        public Form_Ville()
        {
            InitializeComponent();
        }

        int idville;

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Controller_Ville().getAll();
            TxtNom_Ville.Clear();

        }

        private void btnAjoutter_Click(object sender, EventArgs e)
        {
            Ville ville = new Ville()
            {
                NOM = TxtNom_Ville.Text,
               
            };
            if (new Controller_Ville().Ajoutter(ville))
            {
                MessageBox.Show("Ville " + TxtNom_Ville.Text + " bien enregistré ");
                BtnNouveau_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Ville " + TxtNom_Ville.Text + " exist déja ");
            }

        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
              dataGridView1.DataSource = new Controller_Ville().getByName(TxtNom_Ville.Text);
        }

        
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Voulez vous supprimer Ville " + TxtNom_Ville.Text, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (new Controller_Ville().Suprimer(TxtNom_Ville.Text) == true)
                    {
                        BtnNouveau_Click(sender, e);
                        MessageBox.Show("Ville " + TxtNom_Ville.Text + " a été supprimé ");
                    }
                    else
                    {
                        MessageBox.Show("Ville " + TxtNom_Ville.Text + " introuvable ");
                    }

                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Impossible de supprimer cette ville");
            }


            
        }
        int index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }



        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Ville ville = new Ville()
            {
                IDVILLE = idville,
                NOM = TxtNom_Ville.Text,
            };
            if (new Controller_Ville().Modifier(ville))
            {
                BtnNouveau_Click(sender, e);
                MessageBox.Show("Ville " + TxtNom_Ville.Text + " a été Modifié ");
            }
            else
            {
                MessageBox.Show("Ville " + TxtNom_Ville.Text + " introuvable ");
            }


        }

        private void Form_Ville_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Controller_Ville().getAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            idville = Convert.ToInt32(dataGridView1.Rows[index].Cells["IDV"].Value.ToString());
            TxtNom_Ville.Text = dataGridView1.Rows[index].Cells["NOM"].Value.ToString();
        }
    }
}
