using System;
using System.Collections.Generic;
using System.IO;

namespace MinPrime
{
    public class Prime
    {
        public static bool IsPrime(int p)
        {
            bool res = true;
            if (p == 1)
            {
                res = false;
            }
            if (p == 2)
            {
                res = true;
            }
            for (int i = 2; i <= Math.Sqrt(p); ++i)
            {
                if (p % i == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int minn = 1000000;

            string text = File.ReadAllText(@"/Users/diana/Projects/lab2/MinPrime/mpread.txt");
            string[] values = text.Split(' ');
            int n = values.Length;

            List<int> l = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (Prime.IsPrime(int.Parse(values[i])))
                {
                    l.Add(int.Parse(values[i]));
                }
            }
            for (int i = 0; i < l.Count - 1; ++i)
            {
                minn = Math.Min(l[i], minn);
            }
            //Console.WriteLine("Min prime value: " + min);

            File.WriteAllText(@"/Users/diana/Projects/lab2/MinPrime/mpwrite.txt", "Min prime value: " + minn);

        }
    }
}