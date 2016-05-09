using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Comision : BusinessEntity
    {
        private int anioEspecialidad;
        private string descripcion;
        private Plan plan;

        public int AnioEspecialidad
        {
            get
            {
                return anioEspecialidad;
            }
            
            set
            {
                anioEspecialidad = value;
            }
        }

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
    }
}
