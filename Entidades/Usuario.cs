﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : BusinessEntity
    {
        private int idUsuario;
        private string nombreUsuario;
        private string clave;
        private string nombre;
        private string apellido;
        private string email;
        private bool habilitado;

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }
        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
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

        public bool Habilitado
        {
            get
            {
                return habilitado;
            }

            set
            {
                habilitado = value;
            }
        }

        public  Usuario(string nombreUsu, string clave, string nombre, string apellido, string email, bool habilitado) {

            this.NombreUsuario = nombreUsu;
            this.Clave = clave;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Habilitado = habilitado;
        }
        public Usuario() { }
    }
}
