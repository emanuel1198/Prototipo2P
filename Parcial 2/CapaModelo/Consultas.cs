using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{

        public class Consultas
        {
            Conexion cn = new Conexion();
            public void Guardar(string cadena)
            {
                try
                {
                    
                    OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                    consulta.ExecuteNonQuery();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                }
            }

            public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
            {
                //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
                string sql = "SELECT * FROM " + tabla + " ;";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
                return dataTable;
            }

            Conexion con = new Conexion();
            public string[] llenarCmb(string tabla, string campo1, string campo2)
            {

                string[] Campos = new string[300];
                string[] auto = new string[300];
                int i = 0;
                string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";
                try
                {
                    OdbcCommand command = new OdbcCommand(sql, con.conexion());
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                        i++;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
                return Campos;
            }

            public DataTable obtener(string tabla, string campo1, string campo2)
            {
                string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }

        public void dataGrid(string datos, string cadena)
        {
            OdbcDataAdapter consulta = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            datos = Convert.ToString(dt);
        }

    }
    }

