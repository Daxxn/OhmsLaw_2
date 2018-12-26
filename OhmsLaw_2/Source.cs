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

        //Point pointIN;
        //Point pointOUT;
        
        public Source(string name, double voltage, int XposIN, int YposIN, int XposOUT, int YposOUT)
        {
            Name = name;
            SourceVoltage = voltage;
            pointIN = new Point(YposIN, XposIN);
            pointOUT = new Point(YposOUT, XposOUT);
            allSources.Add(this);
            allElements.Add(this);
            Connections = new Connections<Element, Element, Element>(this);
        }

        public double SourceVoltage
        {
            get { return sourceVoltage; }
            set
            {
                sourceVoltage = value;
            }
        }

        /* Sorting Sources for their connections.
        public static double FindAllSourceVoltages(List<Source> Sources)
        {
            for(int i = 0; i < Sources.Count; i++)
            {
                for(int j = 0; j < Sources[i].pointIN.Points.GetLength(1) - 1; j++)
                {
                    if(Sources[i].pointOUT.Points[0,0] == Sources[j].pointOUT.Points[0, 0] && Sources[i].pointOUT.Points[0, 1] == Sources[j].pointOUT.Points[0, 1])
                    {
                        
                    }
                }
                
            }
        }*/
    }
}
