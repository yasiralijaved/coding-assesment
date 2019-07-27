using System;
namespace CoderByte
{
    /**
     * Have the function CheckNums(num1,num2) take both parameters being passed and return the string true if num2 is greater than num1,
     * otherwise return the string false. If the parameter values are equal to each other then return the string -1. 
     *
     *
     *   --Sample Test Cases--
     * 
     *   Input:3, 2
     *   Output:true
     *
     *   Input:3, 3 
     *   Output:-1
     *   
     *   Input:2, 3 
     *   Output:false
     *
     */
    public class Program5 : IProgram
    {
        public void Execute()
        {
            Console.WriteLine(CheckNums(3, 2));
            Console.WriteLine(CheckNums(3, 3));
            Console.WriteLine(CheckNums(2, 3));
        }

        public string CheckNums(int num1, int num2)
        {
            if (num2 > num1) return "true";
            if (num1 == num2) return "-1";
            else return "false";
        }
    }
}
