using CapaVista.Forms_Extras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FormPrincipalMDI : Form
    {
        public FormPrincipalMDI()
        {
            InitializeComponent();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCatalogos ct = new formCatalogos();
            ct.MdiParent = this;
            ct.Show();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProcesos pcs = new formProcesos();
            pcs.MdiParent = this;
            pcs.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInformes inf = new formInformes();
            inf.MdiParent = this;
            inf.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAyuda hlp = new formAyuda();
            hlp.MdiParent = this;
            hlp.Show();
        }
    }
}
