using C43_G05_OOP04.Abstraction;
using C43_G05_OOP04.Operator_Overloading;

namespace C43_G05_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstraction

            Rectangle rectangle = new Rectangle() {Dim01 = 2 , Dim02  = 4};
            Square Square = new Square() { Dim01 = 3, Dim02 = 5};

            //Console.WriteLine(rectangle.Perimetere);
            //Console.WriteLine(Square.Perimetere);

            #endregion

            #region Operator overloading

            Complex c01 = new Complex() { Real = 3 , Image = 1};
            Complex c02 = new Complex() { Real = 3, Image = 4 };

            Console.WriteLine(c01.ToString());

            Console.WriteLine(c02.ToString());

            Complex c03 = c01 + c02;

            Console.WriteLine(c03.ToString());

            #endregion


            // stoped at 54:25

        }
    }
}
