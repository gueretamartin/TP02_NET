using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;

namespace Consola
{
    public class Inicio
    {
        static void Main(string[] args)
        {
            Plan plan = new Plan();
            Plan plan2 = new Plan();
            Personas p = new Personas();
            p.Nombre = "Martin";
            p.Apellido = "Guereta";
            p.Email = "guereta@chimail.com";
            p.FechaNacimiento = DateTime.Parse("01 / 08 / 1996 0:00:00");
            p.Direccion = "asd";
            p.Telefono = "3411";
            p.Legajo = 23;
            TipoPersona tp = new TipoPersona();
            tp.Id = 1;
            tp.DescripcionTipo = "desc";
            p.TipoPersona = tp;
            plan.Id = 1;
            p.Plan = plan;
            ControladorDocentes cd = new ControladorDocentes();
            cd.agregarDocente(p);

            /*plan.DescripcionPlan= "Bueno";
            Especialidad esp = new Especialidad();
            esp.Id = 1;
            esp.NombreEspecialidad = "Base de Datos";
            esp.DescripcionEspecialidad = "Grafos";
            plan.Especialidad = esp;
            new ControladorPlanes().agregarPlan(plan);
            plan2 = new ControladorPlanes().dameUnPlan(1);
            Console.WriteLine(plan2.DescripcionPlan);
            Console.WriteLine(plan2.Especialidad.DescripcionEspecialidad);*/

            Console.ReadKey();
        }
    }
}
