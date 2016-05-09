using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ControladorUsuario : BusinessLogic
    {
        public ControladorUsuario()
        {

        }
        //Instancio un Adaptador de Usuario
        //Me va a devolver los datos de la BD

        private UsuarioDatos usuarioData;
        public UsuarioDatos UsuarioData
        {
            get { return usuarioData; }
            set { usuarioData = value;}
        }
        //Metodo que le pide al Adaptador que le de un suario
        public Usuario dameUno(int id)
        {
            Usuario usr = new Usuario();
            // usu = usuarioData.dameUno(id);
            usr.Id = 3;
            usr.Nombre = "Alan";
            usr.Apellido = "Brado";
            usr.NombreUsuario = "alanbrado";
            usr.Clave = "abrete sesamo";
            usr.Email = "alanbrado@gmail.com";
            usr.Habilitado = true;
            return usr;
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
            UsuarioData.GuardarUsuario(usuario);
        }
        public void eliminarUsuario(Usuario usu)
        {
            Usuario usuario = usu;
            UsuarioData.EliminarUsuario(usuario.Id);
        }
    }
}
