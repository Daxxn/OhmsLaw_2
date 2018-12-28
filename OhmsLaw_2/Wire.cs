using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Wire : Element
    {
        //Connections<Element, Element, Element> connections;

        public Wire() { }
        public Wire(int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            pointIN = new Point(YposIN, XposIN);
            pointOUT = new Point(YposOUT, XposOUT);
            //allWires.Add(this);
            //allElements.Add(this);
            //Connections = new Connections<Element, Element, Element>(this);
        }

        public static void NewWire(int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Wire newWire = new Wire(XposIN, YposIN, XposOUT, YposOUT);
            Element.allElements.Add(newWire);
            Element.allWires.Add(newWire);
        }
    }
}
