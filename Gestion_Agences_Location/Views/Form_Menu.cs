using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Agences_Location.Views
{
    public partial class Form_Menu : Form
    {
        public static Form_Menu frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Form_Menu GetmMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_Menu();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Form_Menu()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;
            this.vILLEToolStripMenuItem.Enabled = true;
            this.aGENCEToolStripMenuItem.Enabled = true;
            this.cLIENTToolStripMenuItem.Enabled = true;
            this.rESPONSABLEToolStripMenuItem.Enabled = true;
            this.tYPEToolStripMenuItem.Enabled = true;
            this.cONTRATToolStripMenuItem.Enabled = true;
            this.tRAVEAUXToolStripMenuItem.Enabled = true;
            this.lOCAUXToolStripMenuItem.Enabled = true;
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.LightSkyBlue;

                    frm.Size = new Size(1360, 620);
                }
            }
        }

        private void vILLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            var f = new Form_Ville();
            f.MdiParent = this;

            f.Show();
        }

        private void aGENCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            var f = new Form_Agence();
            f.MdiParent = this;

            f.Show();
        }
    }
}
