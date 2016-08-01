using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ControladorDocentes
    {

        public Plan damePlan()
        {
            throw new NotImplementedException();
        }

        public void dameTodosPlanes()
        {
            throw new NotImplementedException();
        }

        public void agregarDocente(Personas doc)
        {
            CatalogoDocente cd = new CatalogoDocente();
            cd.agregarDocente(doc);
        }
    }
}
