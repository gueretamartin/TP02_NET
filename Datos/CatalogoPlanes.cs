using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    class CatalogoPlanes : Conexion
    {
        #region
        //Vars
        static List<Plan> planes = new List<Plan>();
        #endregion
        #region
        //Singleton
        private static CatalogoPlanes instance;
        public static CatalogoPlanes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogoPlanes();
                }
                return instance;
            }
        }
        #endregion
        #region
        //Methods
        public List<Plan> buscarPlanes()
        {
            String query = "select * from planes";
            try
            {
                this.getConn();

                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                while (dr.Read())
                {
                    Plan plan = new Plan();
                    plan.DescripcionPlan = (string)dr["descripcionPlan"];
                    Especialidad esp = new Especialidad();
                    //No se si esta bien, le pido al C. de Especialidad que me devuelva la especialidad
                    plan.Especialidad = new CatalogoEspecialidad().dameUno((int)dr["idEspecialidad"]);
                    planes.Add(plan);
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
            return planes;
        }
        public Plan dameUno(int idPlan) {
            Plan plan = new Plan();

            String query = "select * from planes where id = idPlan";
            try
            {
                this.getConn();

                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                while (dr.Read())
                {
                    plan.DescripcionPlan = (string)dr["descripcionPlan"];
                    Especialidad esp = new Especialidad();
                    //No se si esta bien, le pido al C. de Especialidad que me devuelva la especialidad
                    plan.Especialidad = new CatalogoEspecialidad().dameUno((int)dr["idEspecialidad"]);
                    
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


            return plan;
        }
        #endregion


    }
}
