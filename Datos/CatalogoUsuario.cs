using System.Collections.Generic;
using Entidades;


namespace Datos
{
    class CatalogoUsuario : Adapter
    {
        //SINGLETON
        private static CatalogoUsuario instance;
        private CatalogoUsuario() { }
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
        static  List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> buscarUsuarios()
        {
            return usuarios;
        }

        public void agregarUsuarios()
        {
            Usuario usu = new Usuario("martinguereta", "123", "Martin", "Guereta", "tincho_el77@hotmail.com", true);
            usuarios.Add(usu);
            usu = new Usuario("facualvarez", "12345", "Facundo", "Alvarez", "alvfacu@hotmail.com", true);
            usuarios.Add(usu);
            usu = new Usuario("nicocda", "12333", "Nicolas", "Giordano", "nico-cda@hotmail.com", true);
            usuarios.Add(usu);
            usu = new Usuario("peretto5", "123paloma", "Leonardo", "Peretti", "leo.peretti5@gmail.com", true);
            usuarios.Add(usu);
        }
     
        public void modificarUsuario(Usuario usuario )
        {
            foreach(Usuario usu in usuarios)
            {
                if(usuario.NombreUsuario == usu.NombreUsuario)
                {
                    usu.Clave = usuario.Clave;
                    usu.Apellido = usuario.Apellido;
                    usu.Email = usuario.Email;
                    usu.Habilitado = usuario.Habilitado;
                    usu.Nombre = usuario.Nombre;
                }
            }
        }
          
    }
}


/* String query = "select * from usuarios";
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
            }*/


/*
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

       return usu;*/
