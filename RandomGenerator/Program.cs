using System;
using System.Threading;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            // Function randomIn7 generates integers between 1 and 7 (evenly distributed) using function randomIn5() that returns integers between 
            // 1 and 5 (evenly distributed). To display the distribution, an Array with 7 fields was created and the number at the index of the generated
            // number is being incremented. The distribution can be observed in the console.

            int[] arrayCount = new int[7];
            Array.Clear(arrayCount, 0, arrayCount.Length);


            while (true)
            {
                int output = randomIn7();
                arrayCount[output-1]++;
                Console.WriteLine("--" + arrayCount[0] + "--" + "--" + arrayCount[1] + "--" + "--" + arrayCount[2] + "--" + "--" + arrayCount[3] + "--" + "--" + arrayCount[4] + "--" + "--" + arrayCount[5] + "--" + "--" + arrayCount[6] + "--");
                Thread.Sleep(TimeSpan.FromMilliseconds(10));
            }



            int randomIn5()
            {
                Random rand = new Random();
                return rand.Next(1, 6);
            }

            int randomIn7()
            {
                return ((randomIn5() + randomIn5() + randomIn5() + randomIn5() + randomIn5() + randomIn5() + randomIn5() - 7) % 7) + 1;
            }
        }


    }
}
