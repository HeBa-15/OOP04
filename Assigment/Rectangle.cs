using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set ; }
        public double Width { get ; set ; }

        public double Area 
        { get 
            {
                return Length * Width;
             } 
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Area of Rectangle : {Area}");
        }
    }
}
