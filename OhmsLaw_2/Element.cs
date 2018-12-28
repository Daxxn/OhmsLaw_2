using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    abstract class Element : Point
    {
        public static List<Element> allElements = new List<Element>();
        public static List<Resistor> allResistors = new List<Resistor>();
        public static List<Source> allSources = new List<Source>();
        public static List<Wire> allWires = new List<Wire>();

        protected string Name { get; set; }

        protected Point pointIN;
        protected Point pointOUT;

        // Instead of a set 3 dimentional dict, im using a 2D dict with a list controlling it.
        //protected Connections<Element, Element, Element> Connections { get; set; }
        // This should make connections a little more clear.
        protected List<Connection<Element, Element>> Connections { get; set; }
        
        public static void FindPrevious()
        {
            //int iterator = 0;
            foreach (var elm in allElements)
            {
                foreach(var check in allElements)
                {
                    if(elm.pointIN.Points == check.pointOUT.Points)
                    {
                        //elm.Connections.ElmIN = check;
                    }
                }


                /*
                if (iterator - 1 > 0 && allElements[iterator - 1].pointOUT.Points == elm.pointIN.Points)
                {
                    elm.Connections.ElmIN = allElements[iterator - 1];
                }
                iterator++;*/
            }
        }


    }
}
