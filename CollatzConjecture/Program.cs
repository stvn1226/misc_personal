using System;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNum;
            long currNum;
            long operationCount = 0;

            Console.WriteLine("Enter number to start");
            startNum = Int32.Parse(Console.ReadLine());
            currNum = startNum;
            while(currNum != 1)
            {
                if (currNum % 2 == 0)
                {
                    currNum = currNum / 2;
                }
                else{
                    currNum = (currNum * 3) + 1;
                }
                operationCount++;
            }

            Console.WriteLine("End reached in " + operationCount + " operations.");

        }
    }
}
