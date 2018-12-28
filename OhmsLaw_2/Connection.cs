using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Connection<TElementBase, TElementConn> : Element
    {
        public TElementBase elmBase { get; set; }
        public TElementConn elmConn { get; set; }

        public Connection(TElementBase elmB)
        {
            elmBase = elmB;
        }
    }
}
