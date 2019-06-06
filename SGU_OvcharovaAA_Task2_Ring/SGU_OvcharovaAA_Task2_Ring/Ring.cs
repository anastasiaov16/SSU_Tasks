using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU_OvcharovaAA_Task2_Ring
{
    class Ring
    {
        private Point center;
        private int outRad;
        private int inRad;

        public Ring()
        {
        }

        public Ring(Point center, int outRad, int inRad)
        {
            if (outRad < inRad)
            {
                throw new ArgumentException();
            }
            else
            {
                Center = center;
                OutRad = outRad;
                InRad = inRad;
            }
        }

        public Point Center
        {
            get => center;
            set => center = value;
        }

        public int OutRad
        {
            get
            {
                return outRad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else outRad = value;
            }
        }

        public int InRad
        {
            get
            {
                return inRad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else inRad = value;
            }
        }


        public double Square => (Math.PI * (Math.Pow(OutRad, 2)) - (Math.Pow(InRad, 2)));

        public double Summ => (OuterDiam + InnerDiam);

        public double OuterDiam => (2 * OutRad * Math.PI);
        public double InnerDiam => (2 * InRad * Math.PI);
    }
}
