using System;

namespace PRZEDSZK
{
    class Program
    {
        static void Main(string[] args)
        {
            int sol = Int32.Parse(Console.ReadLine());
            int[,] group = new int[2, sol];
            for (int i = 0; i < sol; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                group[0, i] = Int32.Parse(data[0]);
                group[1, i] = Int32.Parse(data[1]);
            }
            for(int i = 0; i < sol; i++)
            {
                int minVal = 0;
                for(int j = 0; j < 2; j++)
                {
                    if (group[j, i] > minVal)
                        minVal = group[j, i];
                }
                while(!((minVal % group[0,i] == 0) && (minVal % group[1, i] == 0)))
                {
                    minVal++;
                }
                Console.WriteLine(minVal);
            }
        }
    }
}
