using System;

namespace PP0501A
{
    class Program
    {
        static void Main(string[] args)
        {
            int sol = Int32.Parse(Console.ReadLine());
            int[,] number = new int[sol, 2];
            for (int i = 0; i < sol; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                number[i, 0] = Int32.Parse(text[0]);
                number[i, 1] = Int32.Parse(text[1]);
            }
            for (int i = 0; i < sol; i++)
            {
                Console.WriteLine(nwd(number[i, 0], number[i, 1]));
            }
        }
        static int nwd(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
