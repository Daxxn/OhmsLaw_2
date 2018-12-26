using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Program
    {
        enum Measurements { Ohms, Volts, Amps};

        static void Main(string[] args)
        {
            #region Instance Creation
            //int numOfResistors = 0;
            //NewResistor(out Element.allResistors, numOfResistors);
            Source V1 = new Source("V1", 12,  0, 0,   2, 0);

            Resistor R1 = new Resistor("R1", 2,  2, 0,   2, 2);
            Resistor R2 = new Resistor("R2", 4,  2, 2,   1, 2);
            Resistor R3 = new Resistor("R3", 6,  1, 2,   1, 1);
            Resistor R4 = new Resistor("R4", 6,  0, 2,   0, 0);
            
            Wire W1 = new Wire(0, 1, 0, 0);
            Wire W2 = new Wire(1, 2, 0, 2);
            Wire W3 = new Wire(1, 1, 0, 1);
            #endregion

            Element.FindPrevious();

            R1.FindSeries(Element.allResistors);
        }

        public static void NewResistor(out List<Resistor> allResistors, int numOfResistors)
        {
            List<Resistor> Resistors = new List<Resistor>();
            switch (numOfResistors)
            {
                default:
                    Console.WriteLine("No resistors specified");
                    Resistors.Add(null);
                    break;
                case 1:
                    Resistor R1 = new Resistor("R1", 2, 0, 1, 1, 1);
                    Resistors.Add(R1);
                    break;
                case 2:
                    Resistor R2 = new Resistor("R1", 2, 0, 1, 1, 1);
                    Resistor R3 = new Resistor("R2", 4, 1, 1, 1, 0);
                    Resistors.Add(R2);
                    Resistors.Add(R3);
                    break;
            }
            allResistors = Resistors;
        }

        public static void NewSources(out List<Source> allSources, int numOfSources)
        {
            List<Source> Sources = new List<Source>();
            switch (numOfSources)
            {
                default:
                    Console.WriteLine("No Sources specified.");
                    break;
                case 1:
                    Source V1 = new Source("V1", 12, 0, 0, 0, 1);
                    break;
                case 2:
                    Source V2 = new Source("V1", 12, 0, 0, 0, 1);
                    Source V3 = new Source("V2", 12, 0, 1, 0, 2);
                    break;
            }
            allSources = Sources;
        }
    }
}
