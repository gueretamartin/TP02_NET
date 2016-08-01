using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    class CatalogoEspecialidad
    {
        #region
        //Vars
        static List<Especialidad> usuarios = new List<Especialidad>();
        #endregion
        #region
        //SINGLETON
        private static CatalogoEspecialidad instance;
        public static CatalogoEspecialidad Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogoEspecialidad();
                }
                return instance;
            }
        }
        #endregion
        #region
        //Methods
        public Especialidad dameUno(int id)
        {
            Especialidad especialidad = new Especialidad();
            return especialidad;
        }

        #endregion


    }
}
