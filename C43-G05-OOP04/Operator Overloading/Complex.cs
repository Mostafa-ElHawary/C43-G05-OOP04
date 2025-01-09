using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP04.Operator_Overloading
{
    internal class Complex
    {
        public int Real { set; get; }
        public int Image { set; get; }
        // operator overloading
        public static Complex operator +(Complex left , Complex right)
        {
            //if(left is null || right ia null ) throw new InvalidProgramException("Invalid operaton") ;
            return new Complex() { 
             
                Real = left?.Real ?? 0  + right?.Real ?? 0,
                Image = left?.Image ?? 0 + right?.Image ?? 0


            };

        }

        public static Complex operator ++(Complex complex)
        {

            if (complex is not null ){
            complex.Real++;

            return complex;
            
            }
            return new Complex();

        }

        public static Complex operator --(Complex complex)
        {

            if (complex is not null) { 
            
                complex.Real--;

            return complex;

            }
            return new Complex();
        }

        public static bool operator >(Complex left , Complex right)
        {
            if(left.Real == right.Real)
                return left.Image > right.Image;
            return left.Real > right.Real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Image < right.Image;
            return left.Real < right.Real;
        }

        public override string ToString()
        {
            //Console.WriteLine($"{Real} , {Image}");
            return $"{Real} , {Image}";
        }
    }
}
