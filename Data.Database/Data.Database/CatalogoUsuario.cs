using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Business.Entities;


namespace Data.Database
{
    class CatalogoUsuario : Conexion
    {
        public List<Usuario> buscarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

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
                    usuarios.Add(usu);
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
            return usuarios;

        }

        public Usuario validarUsuario(string nombre, string pass)
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
        }


    }

}
