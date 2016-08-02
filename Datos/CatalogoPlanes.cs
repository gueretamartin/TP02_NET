using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class CatalogoPlanes : Conexion
    {
        #region
        //Vars
        
        
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
            List<Plan> planes = new List<Plan>();
            String query = "select * from planes";
            try
            {
                this.getConn();

                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                while (dr.Read())
                {
                    Plan plan = new Plan();
                    plan.Id = (int)dr["id_plan"];
                    plan.DescripcionPlan = (string)dr["desc_plan"];
                    Especialidad esp = new Especialidad();
                    plan.Especialidad = new CatalogoEspecialidad().dameUno((int)dr["id_especialidad"]);
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
        public Plan dameUnPlan(int idPlan) {
            Plan plan = new Plan();
            String query = "select * from planes where id_plan = "+idPlan;
            try
            {
                this.getConn();

                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                while (dr.Read())
                {
                    plan.Id = (int)dr["id_plan"];
                    plan.DescripcionPlan = (string)dr["desc_plan"];
                    Especialidad esp = new Especialidad();
                    //No se si esta bien, le pido al C. de Especialidad que me devuelva la especialidad
                    plan.Especialidad = new CatalogoEspecialidad().dameUno((int)dr["id_especialidad"]);
                    
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
        public int ultimoID()
        {
            int id = 0;
            String query = "select MAX(p.id_plan) AS id from planes p";
            try
            {
                this.getConn();
                SqlCommand cmdPlanes = new SqlCommand(query, Con);
                SqlDataReader dr = cmdPlanes.ExecuteReader();
                if (dr.Read())
                {
                    id = (int)dr["id"];
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                closeConn();
            }
            return id;
        }
        public void agregarPlan(Plan plan)
        {
          
            try
            {
                this.getConn();
                string sql = "INSERT INTO Planes(desc_plan,id_especialidad) VALUES( @desc_plan, @id_especialidad)";
                SqlCommand cmdPlanes = new SqlCommand(sql, Con);
                
                cmdPlanes.Parameters.AddWithValue("@desc_plan", plan.DescripcionPlan);
                cmdPlanes.Parameters.AddWithValue("@id_especialidad", plan.Especialidad.Id);

                cmdPlanes.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                closeConn();
            }
        }
        #endregion


    }
}
