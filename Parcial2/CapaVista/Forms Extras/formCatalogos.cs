using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVista.Forms_Extras.CN;

namespace CapaVista.Forms_Extras
{
    public partial class formCatalogos : Form
    {
        public formCatalogos()
        {
            InitializeComponent();
            dataGrid2();
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
            c.obtenerclientes(Convert.ToString(dgridExistencias));
        }

        public void dataGrid2()
        {
            clsConexion1 cn = new clsConexion1();
            string cadena = @"SELECT * FROM sic.existencias;";
            OdbcDataAdapter consulta = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            dgridExistencias.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
