using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physical_formulas
{
    public class Kinetic_energy : Formula
    {
        private double Mass { get; }
        private double Velocity { get; }

        public Kinetic_energy (double mass, double velocity)
        {
            Mass = mass;
            Velocity = velocity;
        }
        public override double Calculate()
        {
            return 0.5 * Mass * Math.Pow(Velocity, 2);
        }
    }
}
