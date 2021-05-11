using System;

namespace MakeArrayConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = new int[] { 3, 0 };
            int t;

            for (int i = 0; i < statues.Length; i++)
            {
                for (int j = i + 1; j < statues.Length; j++)
                {
                    if (statues[j] < statues[i])
                    {
                        t = statues[i];
                        statues[i] = statues[j];
                        statues[j] = t;
                    }
                }
            }
            int tmp = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                if (statues[i + 1] - statues[i] > 1)
                {
                    tmp += statues[i + 1] - statues[i] - 1;
                }
            }

            Console.WriteLine(tmp);
        }
    }
}
