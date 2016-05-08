using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        #region DatosEnMemoria
        // Esta regi�n solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta ser� eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.Id = 1;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.Id = 2;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.Id = 3;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion
        
        CatalogoUsuario cu = new CatalogoUsuario();
        public List<Business.Entities.Usuario> dameTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = cu.buscarUsuarios() ;
            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int Id)
        {
            return Usuarios.Find(delegate(Usuario u) { return u.Id == Id; });
        }

        public void Delete(int ID)
        {
            Usuarios.Remove(this.GetOne(ID));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.states == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.Id > NextID)
                    {
                        NextID = usr.Id;
                    }
                }
                usuario.Id = NextID + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.states == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.Id);
            }
            else if (usuario.states == BusinessEntity.States.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.Id== usuario.Id; })]=usuario;
            }
            usuario.states = BusinessEntity.States.Unmodified;            
        }
    }
}
