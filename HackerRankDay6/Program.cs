using System;

namespace HackerRankDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            for (var i = 0; i < N; i++)
            {
                var s = Console.ReadLine();

                for (var j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(s[j]);
                    }
                }

                Console.Write(" "); 

                for (var j = 0; j < s.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(s[j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
