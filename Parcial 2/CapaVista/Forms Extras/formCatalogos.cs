using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista.Forms_Extras
{
    public partial class formCatalogos : Form
    {
        public formCatalogos()
        {
            InitializeComponent();
            dataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formCatalogos_Load(object sender, EventArgs e)
        {

        }
        public void dataGrid()
        {
            ControladorQ c = new ControladorQ();
            c.obtenerclientes(Convert.ToString(dgridclientes));
        }
    }
}
