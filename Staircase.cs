using System;

class Result
{
    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < i; k++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Result.staircase(n);
    }
}
