using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private String dataBase = "academia";
        private SqlConnection con;
        private String usuario = "root";
        private String contraseña = "root";

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";

        public SqlConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public void getConn()
        {
            String datosConexion = "Data Source=localhost; Initial Catalog=" + dataBase + ";Integrated Security=true; UID=" + usuario + ";PWD=" + contraseña + ";";
            con = new SqlConnection(datosConexion);
            con.Open();
        } 
        
        
        public void closeConn()
        {
        con.Close();
        con = null;
        }
    }
}

