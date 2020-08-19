using System;

namespace PP0502B
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = Int32.Parse(Console.ReadLine());
            int[][] num = new int[test][];
            for(int i = 0; i < test; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                num[i] = new int[Int32.Parse(text[0])];
                for (int j = num[i].Length - 1; j >= 0; j--)
                {
                    num[i][j] = Int32.Parse(text[j+1]);
                    Console.Write(num[i][j] + " ");
                }
            }
        }
    }
}
