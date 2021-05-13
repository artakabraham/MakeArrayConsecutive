using System;

namespace MakeArrayConsecutive
{    
    class Program
    {
        /// <summary>
        /// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. 
        /// Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the 
        /// previous one exactly by 1. He may need some additional statues to be able to accomplish that. Help him figure out the minimum number 
        /// of additional statues needed.
        /// </summary>
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
