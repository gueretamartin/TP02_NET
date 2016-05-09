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
            System.Console.WriteLine("  Seleccione la opcion que desee realizar:"+
                                        "1– Listado General/n"+
                                        "2– Consulta / n"+
                                        "3– Agregar / n"+
                                        "4 - Modificar / n"+
                                        "5 - Eliminar / n"+
                                        "6 - Salir");
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
            System.Console.WriteLine("Usuario: (0)", usu.Id);
            System.Console.WriteLine("\t\tNombre: (0)", usu.Nombre);
            System.Console.WriteLine("\t\tApellido:(0)", usu.Apellido);
            System.Console.WriteLine("\t\tNombre de Usuario: (0)", usu.NombreUsuario);
            System.Console.WriteLine("\t\tClave: (0)", usu.Clave);
            System.Console.WriteLine("\t\tEmail: (0)", usu.Email);
            System.Console.WriteLine("\t\tHabilitado: (0)", usu.Habilitado);
            System.Console.WriteLine();
        }
    }
    
    
}
