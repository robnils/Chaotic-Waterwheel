using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace waterwheel1
{
    //variables for the waterwheel system, used for the graph plotting not for the animation itself
    public class Movement
    {
        private float a;
        public float A
        {
            get { return a; }
            set { a = value; }
        }

        private float b;
        public float B
        {
            get { return b; }
            set { b = value; }
        }

        private float omega;
        public float Omega
        {
            get { return omega; }
            set { if(value>=-100 && value<= 100) omega = value; }
        }
    }
}
