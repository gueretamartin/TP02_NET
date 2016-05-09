using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BusinessEntity
    {
        private int id;

        public BusinessEntity()
        {
            this.states = States.New;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public States states
        {
            get
            {
                return states;
            }

            set
            {
                states = value;
            }
        }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
