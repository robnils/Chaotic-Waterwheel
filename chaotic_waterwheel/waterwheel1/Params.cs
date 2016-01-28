using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace waterwheel1
{
    //parameters of the waterwheel
    public class Params
    {
        private int buckets;
        public int Buckets
        {
            get { return buckets; }
            set { if (value >= 0 && value <= 15) buckets = value; }
        }
        private float theta;
        public float Theta
        {
            get { return theta; }
            set { theta = value; }
        }
        private float inflow;
        public float Inflow
        {
            get { return inflow; }
            set { if (value > 0 && value <=1000) inflow = value; }
        }
        private float outflow;
        public float Outflow
        {
            get { return outflow; }
            set { if (value > 0 && value <= 1000) outflow = value; }
        }

        private float mass;
        public float Mass
        {
            get { return mass; }
            set { mass = value; }
        }        
    }
}
