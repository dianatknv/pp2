using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle{
    class Rectangle
    {
        public double width, height;
        public double area, peri;

        public void rectangle(double width, double height)
        {
        this.width = width;
        this.height = height;
        }

     public double findArea()
    {   
            area = width * height;
        return area;
    }
        public double findPeri()
        {
            peri = 2 * width + 2 * height;
            return peri;
        }
}

    class Program
    {
        static void Main(string[] args)
        {
            double area1, peri1;
            Rectangle rect1 = new Rectangle();
            rect1.rectangle(30, 40);
            area1 = rect1.findArea();
            peri1 = rect1.findPeri();
            Console.Write("Area: ");
            Console.WriteLine(area1);
            Console.Write("Perimeter: ");
            Console.WriteLine(peri1);

            Console.ReadKey();
        }
    }
}
