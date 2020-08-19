using System;

namespace FCTRL3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_przypadkow = Int32.Parse(Console.ReadLine());
            int[] liczba = new int[ilosc_przypadkow];
            for (int i = 0; i < ilosc_przypadkow; i++)
            {
                liczba[i] = Int32.Parse(Console.ReadLine());
                if (liczba[i] <= 1)
                {
                    liczba[i] = 1;
                }
            }
            foreach (int number in liczba)
            {
                if(number >= 10)
                {
                    Console.WriteLine("0 0");
                }
                else
                {
                    int result = 1;
                    for (int j = number; j > 0; j--)
                    {
                        result *= j;
                    }
                    string res_str = result.ToString();
                    if (res_str.Length == 1)
                    {
                        Console.WriteLine("0 " + res_str[0]);
                    }
                    else if (res_str.Length > 1)
                    {
                        Console.WriteLine(res_str[res_str.Length - 2] + " " + res_str[res_str.Length - 1]);
                    }
                }
            }
        }
    }
}
