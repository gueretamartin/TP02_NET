using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Personas
    {
        private string apellido;
        private string direccion;
        private string email;
        private DateTime fechaNacimiento;
        private Plan plan;
        private int legajo;
        private string nombre;
        private string telefono;
        //tipo persona?
        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        internal Plan Plan
        {
            get
            {
                return plan;
            }

            set
            {
                plan = value;
            }
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }

            set
            {
                legajo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
        

    }
}
