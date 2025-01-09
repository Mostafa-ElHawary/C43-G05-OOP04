using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP04.Abstraction
{
    internal class Rectangle : Shape
    {

        //public override double GetAre()
        //{
        //    throw new NotImplementedException();
        //}
        public override double GetAre()
        {
            return Dim02 * Dim01 ;
        }


        public override double Perimetere
        {

            get
            {

                return( Dim02 + Dim01 ) * 2;
            }
        }

    }
}
