using System.Collections.Generic;
using Entidades;
using System;
using System.Data.SqlClient;


namespace Datos
{
    public class CatalogoUsuario : Conexion
    {
        #region Singleton
        //SINGLETON
        private static CatalogoUsuario instance;

        public static CatalogoUsuario Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogoUsuario();
                }
                return instance;
            }
        }
        //ARRAYLIST ESTATICO
        static List<Usuario> usuarios = new List<Usuario>();
        #endregion

        public List<Usuario> buscarUsuarios()
        {
            String query = "select * from usuarios";
            try
            {
                this.getConn();

                SqlCommand cmdUsuarios = new SqlCommand(query, Con);
                SqlDataReader dr = cmdUsuarios.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usu = new Usuario();
                    usu.Apellido = (string)dr["apellido"];
                    usu.Clave = (string)dr["clave"];
                    usu.Email = (string)dr["email"];
                    usu.Habilitado = (bool)dr["habilitado"];
                    usu.Nombre = (string)dr["nombre"];
                    usu.NombreUsuario = (string)dr["nombre_usuario"];
                    usu.Id = (int)dr["id_usuario"];
                    usuarios.Add(usu);
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar usuarios", e);
                throw ExcepcionManejada;
            }
            finally
            {
                closeConn();
            }
            return usuarios;
        }

        public Usuario buscarUsuario(int id)
        { 
            String query = "select * from usuarios where id_usuario = @id";
            Usuario usu = null;
            try
            {
                this.getConn();

                SqlCommand cmdUsuarios = new SqlCommand(query, Con);
                cmdUsuarios.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmdUsuarios.ExecuteReader();
                if (dr.Read())
                {
                    usu = new Usuario();
                    usu.Apellido = (string)dr["apellido"];
                    usu.Clave = (string)dr["clave"];
                    usu.Email = (string)dr["email"];
                    usu.Habilitado = (bool)dr["habilitado"];
                    usu.Nombre = (string)dr["nombre"];
                    usu.NombreUsuario = (string)dr["nombre_usuario"];
                    usu.Id = (int)dr["id_usuario"];
                    
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar el usuario", e);
                throw ExcepcionManejada;
            }
            finally
            {
                closeConn();
            }
            return usu;
        }

        public int ultimoID()
        {
            int id = 0;
            String query = "select MAX(u.id_usuario) AS id from usuarios u";
            try
            {
                this.getConn();
                SqlCommand cmdUsuarios = new SqlCommand(query, Con);
                SqlDataReader dr = cmdUsuarios.ExecuteReader();
                if (dr.Read())
                {
                    id = (int)dr["id"];
                }
            }
            catch (SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al conseguir el ultimo ID", e);
                throw ExcepcionManejada;
            }
            finally
            {
                //dr.Close(); DONDE SE CIERRA?
                closeConn();
            }
            return id;
        }
        public void agregarUsuario(Usuario us)
        {
            int maxID = this.ultimoID() + 1;
            try
            {
                this.getConn();
                string sql = "INSERT INTO Usuario(id_usuario, nombre_usuario, clave, habilitado, nombre, apellido, email, cambia_clave, id_persona) "+
                    "VALUES(@id_usuario, @nombre_usuario, @clave, @habilitado, @nombre,@apellido, @email, @clave, @id_persona) "+
                    "select @@identity";
                SqlCommand cmdUsuarios = new SqlCommand(sql, Con);
                //   cmdUsuarios.Parameters.AddWithValue("@id_usuario", us.IdUsuario);
                cmdUsuarios.Parameters.AddWithValue("@nombre_usuario", us.NombreUsuario);
                cmdUsuarios.Parameters.AddWithValue("@clave", us.Clave);
                cmdUsuarios.Parameters.AddWithValue("@habilitado", us.Habilitado);
                cmdUsuarios.Parameters.AddWithValue("@nombre", us.Nombre);
                cmdUsuarios.Parameters.AddWithValue("@apellido", us.Apellido);
                cmdUsuarios.Parameters.AddWithValue("@email", us.Email);
                cmdUsuarios.Parameters.AddWithValue("@cambia_clave", "False");
                cmdUsuarios.Parameters.AddWithValue("@id_persona", maxID);
                us.Id = Decimal.ToInt32((decimal)cmdUsuarios.ExecuteScalar()); // Obtiene el ID que asigno la BD autoincrementalmente
                cmdUsuarios.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar usuario", e);
                throw ExcepcionManejada;
            }
            finally
            {
                closeConn();
            }
        }
    
        public void eliminarUsuario(Usuario us)
        {
            try
            {
                this.getConn();
                string sql = " DELETE Usuario WHERE id_usuario = @id";
                SqlCommand cmdUsuarios = new SqlCommand(sql, Con);
                cmdUsuarios.Parameters.AddWithValue("@id", us.Id);
                cmdUsuarios.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar usuario", e);
                throw ExcepcionManejada;
            }
            finally
            {
                closeConn();
            }
        }

        public void modificarUsuario(Usuario us)
        {
             try
            {
                this.getConn();
                string sql = "UPDATE Usuario SET nombre_usuario = @nombre_usuario , clave = @clave , habilitado = @habilitado, nombre = @nombre , apellido = @apellido, " +
                    "email = @email, cambia_clave = @cambia_clave WHERE id_usuario @id_usuario";
                SqlCommand cmdUsuarios = new SqlCommand(sql, Con);
                //   cmdUsuarios.Parameters.AddWithValue("@id_usuario", us.IdUsuario);
                cmdUsuarios.Parameters.AddWithValue("@nombre_usuario", us.NombreUsuario);
                cmdUsuarios.Parameters.AddWithValue("@clave", us.Clave);
                cmdUsuarios.Parameters.AddWithValue("@habilitado", us.Habilitado);
                cmdUsuarios.Parameters.AddWithValue("@nombre", us.Nombre);
                cmdUsuarios.Parameters.AddWithValue("@apellido", us.Apellido);
                cmdUsuarios.Parameters.AddWithValue("@email", us.Email);
                cmdUsuarios.Parameters.AddWithValue("@cambia_clave", "False");
                cmdUsuarios.Parameters.AddWithValue("@id_persona", us.Id);
                cmdUsuarios.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar usuario", e);
                throw ExcepcionManejada;
            }
            finally
            {
                closeConn();
            }
        }




        /*   public Usuario validarUsuario(string nombre, string pass)
      {
          Usuario usu = null;
          string query = "Select * from usuarios where nombre_usuario = @nombre and clave = @pass";
          try
          {
              this.getConn();
              SqlCommand cmdUsuarios = new SqlCommand(query, Con);
              cmdUsuarios.Parameters.AddWithValue(@nombre, nombre);
              cmdUsuarios.Parameters.AddWithValue(@pass, pass);
              SqlDataReader dr = cmdUsuarios.ExecuteReader();

              while (dr.Read())
              {
                  usu = new Usuario();
                  usu.Apellido = (string)dr["apellido"];
                  usu.Clave = (string)dr["clave"];
                  usu.Email = (string)dr["email"];
                  usu.Habilitado = (bool)dr["habilitado"];
                  usu.Nombre = (string)dr["nombre"];
                  usu.NombreUsuario = (string)dr["nombre_usuario"];

              }
              dr.Close();
          }
          catch (SqlException e)
          {
              Console.WriteLine(e.Message);
          }
          finally
          {
              this.closeConn();
          }

          return usu;
          }*/
    }
}
