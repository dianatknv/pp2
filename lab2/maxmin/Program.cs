using System;
using System.IO;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"/Users/diana/Projects/lab2/maxmin/mm.txt");
            string[] values = text.Split(' ');
            int n = values.Length;

            int[] x = new int[n];
            int max = int.MinValue;

            for (int i = 0; i < n; ++i){
                x[i] = int.Parse(values[i]);
                if (x[i] > max)
                    max = x[i];
            }

            int[] y = new int[n];
            int min = int.MaxValue;
            for (int i = 0; i < n; ++i){
                x[i] = int.Parse(values[i]);
                if (x[i] < min)
                    min = x[i];
            }
      
            string[] w = { "Max value equal to " + max, "Min value equal to " + min };
            File.WriteAllLines(@"/Users/diana/Projects/lab2/maxmin/write.txt", w);
   
            Console.ReadKey();
        }
    }
}