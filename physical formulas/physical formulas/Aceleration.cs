using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physical_formulas
{
    public class Aceleration : Formula
    {
        private double InitialVelocity { get; }
        private double FinalVelocity { get; }
        private double Time { get; }

        public Aceleration(double initialVelocity, double finalVelocity, double time)
        {
            InitialVelocity = initialVelocity;
            FinalVelocity = finalVelocity;
            Time = time;
        }
        public override double Calculate()
        {
            return (FinalVelocity - InitialVelocity) / Time;
        }
    }
}
