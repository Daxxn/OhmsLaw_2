using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Wire : Element
    {
        //Point pointIN;
        //Point pointOUT;

        //Connections<Element, Element, Element> connections;

        public Wire() { }
        public Wire(int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            pointIN = new Point(YposIN, XposIN);
            pointOUT = new Point(YposOUT, XposOUT);
            allWires.Add(this);
            allElements.Add(this);
            Connections = new Connections<Element, Element, Element>(this);
        }
    }
}
