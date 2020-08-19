using System;

namespace RNO_DOD
{
    class Program
    {
        static void Main(string[] args)
        {
            int sol = Int32.Parse(Console.ReadLine());
            int[] amount = new int[sol];
            int[][] numbers = new int[sol][];
            for(int i =0;i < sol; i++)
            {
                amount[i] = Int32.Parse(Console.ReadLine());
                numbers[i] = new int[amount[i]];
                string[] add = Console.ReadLine().Split(' ');
                for(int j = 0; j < amount[i]; j++)
                {
                    numbers[i][j] = Int32.Parse(add[j]);
                }
            }
            for(int i = 0; i < sol; i++)
            {
                int sum = 0;
                foreach (int number in numbers[i])
                {
                    sum += number;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
