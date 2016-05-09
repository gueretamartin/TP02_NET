using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Curso
    {
        private int anioCalendario;
        private int cupo;
        private string descripcion;
        private Comision comision;
        private Materia materia;

        public int AnioCalendario
        {
            get
            {
                return anioCalendario;
            }

            set
            {
                anioCalendario = value;
            }
        }

        public int Cupo
        {
            get
            {
                return cupo;
            }

            set
            {
                cupo = value;
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

        internal Comision Comision
        {
            get
            {
                return comision;
            }

            set
            {
                comision = value;
            }
        }

        internal Materia Materia
        {
            get
            {
                return materia;
            }

            set
            {
                materia = value;
            }
        }
    }
}
