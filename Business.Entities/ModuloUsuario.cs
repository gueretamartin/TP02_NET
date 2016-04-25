using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        int idUsuario;
        int idModulo;
        bool permiteAlta;
        bool permiteBaja;
        bool permiteModificacion;
        bool permiteConsulta;

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

        public int IdModulo
        {
            get
            {
                return idModulo;
            }

            set
            {
                idModulo = value;
            }
        }

        public bool PermiteAlta
        {
            get
            {
                return permiteAlta;
            }

            set
            {
                permiteAlta = value;
            }
        }

        public bool PermiteBaja
        {
            get
            {
                return permiteBaja;
            }

            set
            {
                permiteBaja = value;
            }
        }

        public bool PermiteModificacion
        {
            get
            {
                return permiteModificacion;
            }

            set
            {
                permiteModificacion = value;
            }
        }

        public bool PermiteConsulta
        {
            get
            {
                return permiteConsulta;
            }

            set
            {
                permiteConsulta = value;
            }
        }
    }
}
