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
            // set to true to include console inputs;
            bool testingInput = true;

            if(testingInput == true)
            {
                ConsoleInputsMain();
            }
            else
            {
                #region
                //int numOfResistors = 0;
                //NewResistor(out Element.allResistors, numOfResistors);
                Source V1 = new Source("V1", 12, 0, 0, 2, 0);

                Resistor R1 = new Resistor("R1", 2, 2, 0, 2, 2);
                Resistor R2 = new Resistor("R2", 4, 2, 2, 1, 2);
                Resistor R3 = new Resistor("R3", 6, 1, 2, 1, 1);
                Resistor R4 = new Resistor("R4", 6, 0, 2, 0, 0);

                Wire W1 = new Wire(0, 1, 0, 0);
                Wire W2 = new Wire(1, 2, 0, 2);
                Wire W3 = new Wire(1, 1, 0, 1);
                #endregion
            }
            Element.FindPrevious();

            //R1.FindSeries(Element.allResistors);
        }

        public static void ConsoleInputsMain()
        {
            bool newElm = true;
            while (newElm)
            {
                Console.WriteLine("New element?");
                string input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    newElm = true;
                    NewElement();
                }
                else
                {
                    newElm = false;
                }
            }
        }

        public static void NewElement()
        {
            string name;
            double value;
            int XposI;
            int YposI;
            int XposO;
            int YposO;

            Console.WriteLine("Source, Resistor or Wire?");
            string input = Console.ReadLine();
            if (input.ToLower().Contains("c") || input.ToLower() == "s" || input.ToLower().Contains("source"))
            {
                Console.WriteLine("Source name?");
                name = Console.ReadLine();

                Console.WriteLine("Source voltage?");
                input = Console.ReadLine();
                value = Double.Parse(input);

                Console.WriteLine("Point in?");
                // eventually this will be X,Y and ill parse it down.
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposI = Int32.Parse(input);

                Console.WriteLine("Point in?");
                // And do better error correction. =\
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposI = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // this should work,
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposO = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // for the momoent.
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposO = Int32.Parse(input);

                Source.NewSource(name, value, YposI, XposI, YposO, XposO);
            }
            else if(input.ToLower().Contains("res") || input.ToLower().Contains("resistor"))
            {
                Console.WriteLine("Resistor name?");
                name = Console.ReadLine();

                Console.WriteLine("Resistance?");
                input = Console.ReadLine();
                value = Double.Parse(input);

                Console.WriteLine("Point in?");
                // eventually this will be X,Y and ill parse it down.
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposI = Int32.Parse(input);

                Console.WriteLine("Point in?");
                // And do better error correction. =\
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposI = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // this should work,
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposO = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // for the momoent.
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposO = Int32.Parse(input);

                Resistor.NewResistor(name, value, YposI, XposI, YposO, XposO);
            }
            else if (input.ToLower().Contains("w") || input.ToLower().Contains("wire"))
            {
                Console.WriteLine("Point in?");
                // eventually this will be X,Y and ill parse it down.
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposI = Int32.Parse(input);

                Console.WriteLine("Point in?");
                // And do better error correction. =\
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposI = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // this should work,
                Console.WriteLine("X Position?");
                input = Console.ReadLine();
                XposO = Int32.Parse(input);

                Console.WriteLine("Point out?");
                // for the momoent.
                Console.WriteLine("Y Position?");
                input = Console.ReadLine();
                YposO = Int32.Parse(input);

                Wire.NewWire(YposI, XposI, YposO, XposO);
            }
            else
            {
                Console.WriteLine("Not a valid input..");
            }
        }
    }
}
