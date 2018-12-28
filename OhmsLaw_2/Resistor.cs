using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Resistor : Element
    {
        private double resistance;
        private double branchRes { get; set; }

        //public Connections<Element, Element, Element> connections;
        
        public Resistor(string name, double resistance, int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Name = name;
            Resistance = resistance;
            pointIN = new Point(YposIN, XposIN);
            pointOUT = new Point(YposOUT, XposOUT);
            //allResistors.Add(this);
            //allElements.Add(this);
            //Connections = new Connections<Element, Element, Element>(this);
        }
        
        // Properties :
        public double Resistance
        {
            get { return resistance; }
            set
            {
                if( !Double.IsNaN(value))
                {
                    resistance = value;
                }
                else
                {
                    Console.WriteLine("ERROR : this is not a number.");
                }
            }
        }

        public static void NewResistor(string name, double resistance, int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Resistor newResistor = new Resistor(name, resistance, XposIN, YposIN, XposOUT, YposOUT);
            Element.allElements.Add(newResistor);
            Element.allResistors.Add(newResistor);
        }
        
        // non-static Methods :
        public void FindSeries(List<Resistor> allResistors)
        {
            for(int i = 0; i < allResistors.Count; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    if(allResistors[i].pointIN.Points[0, 0] == allResistors[j].pointIN.Points[0, 0] && allResistors[i] != allResistors[j])
                    {
                        allResistors[i].branchRes += allResistors[i].Resistance;
                    }
                    else
                    {
                        allResistors[i].branchRes = allResistors[i].Resistance;
                    }
                }
            }
        }

        /*
        public void FindConnection(List<Element> allElements, object source)
        {
            for(int i = 0; i < allElements.Count; i++)
            {
                if(allElements[i].Points == this)
            }
        }*/

    }
}
