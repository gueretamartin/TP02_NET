using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso
    {
        private Curso curso;
        private Personas docente;
        // tipoCargo? private TipoCargo cargo;
        internal Curso Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        internal Personas Docente
        {
            get
            {
                return docente;
            }

            set
            {
                docente = value;
            }
        }
     
    }
}
