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
    public partial class Form_Responsable : Form
    {
        public Form_Responsable()
        {
            InitializeComponent();
        }

        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Controller_Responsable().getAll();
            TxtNomPrenomRes.Focus();
        }
    }
}
