using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;


namespace Consola
{
    
    public class Usuario
    {
        private ControladorUsuario UsuarioNegocio = new ControladorUsuario();
        public void Menu()
        {
            Console.WriteLine("  Seleccione la opcion que desee realizar:");
            Console.WriteLine("1– Listado General");
            Console.WriteLine("2– Consulta");
            Console.WriteLine("3– Agregar ");
            Console.WriteLine("4 - Modificar ");
            Console.WriteLine("5 - Eliminar");
            Console.WriteLine("6 - Salir");
            string opcion = System.Console.ReadLine();
            int rta = int.Parse(opcion);
            if (rta == 1) {

                this.MostrarDatos(UsuarioNegocio.dameUno(1));

            }
        }
       
        public void ListadoGeneral()
        {
            System.Console.Clear();
            List<Entidades.Usuario> usuarios = UsuarioNegocio.dameTodos();
            foreach(Entidades.Usuario usu in usuarios)
            {
                MostrarDatos(usu);
            }

        }
        public void Consultar()
        {

        }
        public void Agregar()
        {

        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }
        public void MostrarDatos(Entidades.Usuario usu)
        {
            Console.WriteLine("\t\tUsuario:" +  usu.Id);
            System.Console.WriteLine("\t\tNombre: "+ usu.Nombre);
            Console.WriteLine("\t\tApellido: "+ usu.Apellido);
            System.Console.WriteLine("\t\tNombre de Usuario: "+ usu.NombreUsuario);
            System.Console.WriteLine("\t\tClave: "+ usu.Clave);
            System.Console.WriteLine("\t\tEmail: "+ usu.Email);
            System.Console.WriteLine("\t\tHabilitado: "+ usu.Habilitado);
            System.Console.ReadKey();
        }
    }
    
    
}
