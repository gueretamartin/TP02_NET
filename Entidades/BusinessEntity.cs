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
        private States states;
        public States State
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
