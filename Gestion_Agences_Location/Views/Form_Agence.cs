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

        //todo: a complre apres la creation de controlleur Ville
        private void Agence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Controller_Agence().getAll();
            CmbVille.DataSource = new Controller_Ville().getAll();
            CmbVille.DisplayMember = "NOM";
            CmbVille.ValueMember = "IDVILLE";

            //CmbVille.DataSource = "";
            //CmbVille.DisplayMember = "NOM";
            //CmbVille.ValueMember = "IDVille";
        }

        //TODO: Modification apres ajout combobox Ville et Ville
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
        }
    }
}
