﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modulo : BusinessEntity
    {
        private string descripcionModulo;

        public string DescripcionModulo
        {
            get
            {
                return descripcionModulo;
            }

            set
            {
                descripcionModulo = value;
            }
        }
    }
}
