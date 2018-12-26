using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw_2
{
    class Point
    {
        private int[,] points = new int[1, 2];
        double voltage;
        double current;

        public Point() { }
        public Point(int posX, int posY)
        {
            Points[0, 0] = posY;
            Points[0, 1] = posX;
            Voltage = 0;
            Current = 0;
        }


        public int[,] Points
        {
            get { return points; }
            set
            {
                points = value;
            }
        }

        public double Voltage
        {
            get { return voltage; }
            set
            {
                voltage = value;
            }
        }

        public double Current
        {
            get { return current; }
            set
            {
                current = value;
            }
        }
    }
}
