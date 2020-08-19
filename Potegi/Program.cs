using System;

namespace PA05_POT
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = Int32.Parse(Console.ReadLine());
            double[] podstawa = new double[ile];
            double[] potega = new double[ile];
            for (int i = 0; i < ile; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                podstawa[i] = Double.Parse(numbers[0]);
                potega[i] = Double.Parse(numbers[1]);
            }
            for (int i = 0; i < podstawa.Length; i++)
            {
                string x = Math.Pow(podstawa[i], potega[i]).ToString();

                Console.WriteLine(x[x.Length - 1]);
            }
        }
    }
}
