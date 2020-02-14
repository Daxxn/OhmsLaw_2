using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Source : Element
    {
        private double sourceVoltage;

        public Source(string name, double voltage, int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Name = name;
            SourceVoltage = voltage;
            pointIN = new Point(YposIN, XposIN);
            pointOUT = new Point(YposOUT, XposOUT);
            //allSources.Add(this);
            //allElements.Add(this);
            //Connections = new Connections<Element, Element, Element>(this);
        }

        public double SourceVoltage
        {
            get { return sourceVoltage; }
            set
            {
                sourceVoltage = value;
            }
        }

        public static void NewSource(string name, double value, int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Source newSource = new Source(name, value, XposIN, YposIN, XposOUT, YposOUT);
            Element.allElements.Add(newSource);
            Element.allSources.Add(newSource);
        }
    }
}
