using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class ControladorPlanes
    {
        CatalogoPlanes cp = new CatalogoPlanes();

        public void agregarPlan(Plan plan) { 
       
        cp.agregarPlan(plan);
        }

        public Plan dameUnPlan(int id)
        {
            Plan p = new Plan();
            p = cp.dameUnPlan(id);
            return p;
        }

        public List<Plan> getAllPlanes()
        {
            List<Plan> planes = new List<Plan>();
            planes = cp.buscarPlanes();
            return planes;
        }
    }
}
