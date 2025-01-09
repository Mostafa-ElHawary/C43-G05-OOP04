using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP04.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimetere
        {
            get { return Dim01 * 4; }
        }

        public override double GetAre()
        {
            return Dim02 * Dim01 ;
        }
    }
}
