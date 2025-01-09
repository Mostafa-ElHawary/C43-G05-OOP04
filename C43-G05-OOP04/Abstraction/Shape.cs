using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP04.Abstraction
{
    internal abstract class Shape
    {
        public double Dim01 { set; get; }
        public double Dim02 { set; get; }

        public abstract double GetAre();
            
        public abstract double Perimetere { get; }

        public  void Print() {
            Console.WriteLine("Print shap");


        }
    }
}
