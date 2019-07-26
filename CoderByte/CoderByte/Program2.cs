using System;
namespace CoderByte
{
    /**
     * Have the function SimpleAdding(num) add up all the numbers from 1 to num.
     * For example: if the input is 4 then your program should return 10 because 1 + 2 + 3 + 4 = 10.
     * For the test cases, the parameter num will be any number from 1 to 1000. 
     *
     *
     *   --Sample Test Cases--
     * 
     *   Input:12
     *   Output:78
     *
     *   Input:140
     *   Output:9870
     *
     */
    public class Program2 : IProgram
    {
        public void Execute()
        {
            Console.WriteLine(SimpleAdding(12));
            Console.WriteLine(SimpleAdding(140));
        }

        public int SimpleAdding(int num)
        {

            int result = 0;

            if (num <= 0)
            {
                return num;
            }

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }

            return result;

        }
    }
}
