using System;

namespace Circle
{
    class Circle
    {

        public double radius, diameter, area, circumference;
        public const double PI = 3.14159;

        public void circle(double radius)
        {
            this.radius = radius;
        }

        public double findDiameter()
        {
            diameter = radius * 2;
            return diameter;
        }


        public double findArea(){
            area = PI * radius * radius;
            return area;
        }

        public double findCircumference()
        {
            circumference = 2 * PI * radius;
            return circumference;
          
        }
      
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle’s radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle ans = new Circle();
            //radius = ans.radius;

            Console.WriteLine("The area of the circle is " + ans.findArea());
            Console.WriteLine("The Diameter of the circle is " + ans.findDiameter());
            Console.WriteLine("The Circumference of the circle is " + ans.findCircumference());

            Console.ReadKey();
        }
    }
}
