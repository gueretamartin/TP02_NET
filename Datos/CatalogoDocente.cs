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
            int maxID = this.ultimoID() + 1;
            try
            {
                this.getConn();
                string sql = "INSERT INTO Personas(idPersonas, apellido, direccion, email, legajo,  nombre, telefono,idPlan, idTipoPersona,) VALUES(@idPersonas, @apellido, @direccion, @email, @legajo,@nombre, @telefono, @idPlan, @idTipoPersona)";
                SqlCommand cmdDocentes = new SqlCommand(sql, Con);
               // cmdDocentes.Parameters.AddWithValue("@idPersonas", doc.IdPersona);
                cmdDocentes.Parameters.AddWithValue("@apellido", doc.Apellido);
                cmdDocentes.Parameters.AddWithValue("@direccion", doc.Direccion);
                cmdDocentes.Parameters.AddWithValue("@email", doc.Email);
                cmdDocentes.Parameters.AddWithValue("@legajo", doc.Legajo);
                cmdDocentes.Parameters.AddWithValue("@nombre", doc.Nombre);
                cmdDocentes.Parameters.AddWithValue("@telefono", doc.Telefono);
                //Falta el PLAN Y EL TIPO DE PERSONA
                cmdDocentes.ExecuteNonQuery();
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
