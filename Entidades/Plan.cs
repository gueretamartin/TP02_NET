﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Plan : BusinessEntity 
    {
        private string descripcion;
        private int idEspecialidad;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int IdEspecialidad
        {
            get
            {
                return idEspecialidad;
            }

            set
            {
                idEspecialidad = value;
            }
        }
    }
}
