using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Student
{
    class Studentik
    {
        public string name;
        public string sname;
        public double gpa;

  
        public Studentik(string name, string sname, double gpa)
        {
            this.name = name;
            this.sname = sname;
            this.gpa = gpa;
        }

        public Studentik()
        {
        }

        public void Read()
        {
            name = Console.ReadLine();
            sname = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void Print()
        {
            Console.WriteLine(sname + ' ' + name + ' ' + gpa);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Studentik> l = new List<Studentik>();
            Random r = new Random();

            int n = r.Next(5, 10);

            for (int i = 0; i < n; ++i)
            {
                double gpa = r.Next(1, 4) + r.NextDouble();
                Studentik s = new Studentik("A" + i, "B" + i, gpa);
                l.Add(s);
            }

            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (l[i].gpa > l[j].gpa)
                    {
                        Studentik t = l[i];
                        l[i] = l[j];
                        l[j] = t;
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                l[i].Print();
            }
        }
    }
}
        

