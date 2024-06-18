using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physical_formulas
{
    public class Velocity : Formula
    {
        private double Distance {  get; }
        private double Time { get; }

        public Velocity(double distance, double time)
        {
            Distance = distance;
            Time = time;
        }
        public override double Calculate()
        {
            return Distance / Time;
        }
    }
}
