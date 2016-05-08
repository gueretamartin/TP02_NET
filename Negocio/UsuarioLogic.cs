using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Negocio
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic()
        {

        }
        //Instancio un Adaptador de Usuario
        //Me va a devolver los datos de la BD

        private UsuarioAdapter usuarioData;
        public UsuarioAdapter UsuarioData
        {
            get { return usuarioData; }
            set { usuarioData = value;}
        }
        //Metodo que le pide al Adaptador que le de un suario
        public Usuario dameUno(int id)
        {
            Usuario usu = new Usuario();
            usu = UsuarioData.GetOne(id);
            return usu;
        }

        public List<Usuario> dameTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioData.dameTodos();
            return usuarios;
        }

        public void guardarUsuario(Usuario usu)
        {
            Usuario usuario = usu;
            UsuarioData.Save(usuario);
        }
        public void eliminarUsuario(Usuario usu)
        {
            Usuario usuario = usu;
            UsuarioData.Delete(usuario.Id);
        }
    }
}
