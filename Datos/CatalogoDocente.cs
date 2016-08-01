using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
namespace Datos
{
    public class CatalogoDocente : Conexion
    {
        #region
        //Vars
        static List<Personas> usuarios = new List<Personas>();
        #endregion
        #region
        //SINGLETON
        private static CatalogoDocente instance;
        public static CatalogoDocente Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogoDocente();
                }
                return instance;
            }
        }
        #endregion
        #region
        //Methods

        
        public void agregarDocente(Personas doc)
        {
            
            try
            {
                this.getConn();
                string sql = "INSERT INTO Personas (nombre, apellido, direccion, email,  telefono, fecha_nac,legajo,tipo_persona,id_plan) VALUES (@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @id_tipo_persona,@id_plan)";
                SqlCommand cmdDocentes = new SqlCommand(sql, Con);
                cmdDocentes.Parameters.AddWithValue("@nombre", doc.Nombre);
                cmdDocentes.Parameters.AddWithValue("@apellido", doc.Apellido);
                cmdDocentes.Parameters.AddWithValue("@direccion", doc.Direccion);
                cmdDocentes.Parameters.AddWithValue("@email", doc.Email);
                cmdDocentes.Parameters.AddWithValue("@telefono", doc.Telefono);
                cmdDocentes.Parameters.AddWithValue("@fecha_nac", doc.FechaNacimiento);
                cmdDocentes.Parameters.AddWithValue("@legajo", doc.Legajo);
                //Modificar y traer un tipo de persona real
                cmdDocentes.Parameters.AddWithValue("@id_tipo_persona", 1);
                cmdDocentes.Parameters.AddWithValue("@id_plan", doc.Plan.Id);
                cmdDocentes.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                String asd = Console.ReadLine();
            }
            finally
            {
                closeConn();
            }
        }

        public int ultimoID()
        {
            int id = 0;
            String query = "select MAX(p.idPersonas) AS id from personas p";
            try
            {
                this.getConn();
                SqlCommand cmdUsuarios = new SqlCommand(query, Con);
                SqlDataReader dr = cmdUsuarios.ExecuteReader();
                if (dr.Read())
                {
                    id = (int)dr["idPersonas"];
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
        #endregion





    }
}
