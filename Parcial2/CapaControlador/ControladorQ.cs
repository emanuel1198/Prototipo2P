using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    
    public class ControladorQ
    {
        Consultas con = new Consultas();
        public void obtenerclientes(string tabla)
        {
            string cadena = "SELECT * FROM sic.clientes;";
            con.dataGrid(tabla, cadena);
            
        }
        public void obtenerexistencias(string tabla)
        {
            string cadena = @"SELECT * FROM sic.existencias;" ;
            con.dataGrid(tabla, cadena);

        }
    }
}
