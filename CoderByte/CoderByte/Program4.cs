using System;
namespace CoderByte
{
    /**
     * Have the function SimpleSymbols(str) take the str parameter being passed and determine if it is an acceptable
     * sequence by either returning the string true or false. The str parameter will be composed of + and = symbols
     * with several characters between them(ie. ++d+===+c++==a) and for the string to be true each letter must be surrounded by a + symbol.
     * So the string to the left would be false.
     * The string will not be empty and will have at least one letter.
     *
     *
     *   --Sample Test Cases--
     * 
     *   Input:"d+=3=+s+"
     *   Output:true
     *
     *   Input:"f++d+"
     *   Output:false
     *
     */
    public class Program4 : IProgram
    {
        public void Execute()
        {
            Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
            Console.WriteLine(SimpleSymbols("f++d+"));
        }

        public string SimpleSymbols(string str)
        {

            if (str == null || str.Length <= 0)
            {
                return "false";
            }
            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = str.Length - 1;

            int firstCharIndex = Array.IndexOf(alphabets, Char.ToLower(str[0]));
            int lastCharIndex = Array.IndexOf(alphabets, Char.ToLower(str[length]));

            // First and Last positions should not contain alphabets
            if (firstCharIndex != -1 || lastCharIndex != -1)
            {
                return "false";
            }

            for (int i = 0; i <= length; i++)
            {
                int index = Array.IndexOf(alphabets, Char.ToLower(str[0]));
                // If it is an alphabet
                if (index != -1)
                {
                    // Check if it is surrounded by +
                    if ((i - 1 < 0) || (i + 1 > length))
                    {
                        return "false";
                    }
                    else
                    {
                        if (str[i - 1] == '+' && str[i + 1] == '+')
                        {
                            return "true";
                        }
                        else
                        {
                            return "false";
                        }
                    }
                }
            }

            return "true";

        }
    }
}
