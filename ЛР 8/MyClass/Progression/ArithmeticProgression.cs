using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression
{
    class ArithmeticProgression : IProgression
    {
        public int a1 { get; private set; }
        public int d { get; private set; }

        public ArithmeticProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }

        public double GetElement(int k)
        {
            double element = this.a1 + this.d * (k - 1);
            return element;
        }
    }
}
