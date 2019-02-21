using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class GeometricProgression : IProgression
    {
        public int b1 { get; private set; }
        public int q { get; private set; }

        public GeometricProgression(int b1, int q)
        {
            this.b1 = b1;
            this.q = q;
        }

        public double GetElement(int k)
        {
            double element = this.b1 * Math.Pow(this.q, k - 1);
            return element;
        }
    }
}
