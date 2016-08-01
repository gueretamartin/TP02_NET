using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class CatalogoEspecialidad : Conexion
    {
        #region
        //Vars
        static List<Especialidad> usuarios = new List<Especialidad>();
        #endregion
        #region
        //SINGLETON
        private static CatalogoEspecialidad instance;
        public static CatalogoEspecialidad Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogoEspecialidad();
                }
                return instance;
            }
        }
        #endregion
        #region
        //Methods
        public Especialidad dameUno(int idEspecialidad)
        {
            Especialidad especialidad = new Especialidad();
            String query = "select * from especialidades where id_especialidad = " + idEspecialidad;
            try
            {
                this.getConn();

                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                while (dr.Read())
                {
                    especialidad.Id = (int)dr["id_especialidad"];
                    especialidad.DescripcionEspecialidad = (string)dr["desc_especialidad"];
                    Especialidad esp = new Especialidad();
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                closeConn();
            }
            return especialidad;
        }

        #endregion


    }
}
