using System;
namespace CoderByte
{
    /**
     * Have the function LetterCapitalize(str) take the str parameter being passed and capitalize the first letter of each word.
     * Words will be separated by only one space. 
     *
     *
     *   --Sample Test Cases--
     * 
     *   Input:"hello world"
     *   Output:Hello World
     *
     *   Input:"i ran there"
     *   Output:I Ran There
     *
     */
    public class Program3 : IProgram
    {
        public void Execute()
        {
            Console.WriteLine(LetterCapitalize("hello world"));
            Console.WriteLine(LetterCapitalize("i ran there"));
        }

        public string LetterCapitalize(string str)
        {


            int length = str.Length;
            string answer = "";

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    answer = answer + Char.ToUpper(str[i]);
                }
                else if (i - 1 >= 0)
                {
                    if (str[i - 1] == ' ')
                    {
                        answer = answer + Char.ToUpper(str[i]);
                    }
                    else
                    {
                        answer = answer + str[i];
                    }
                }
                else
                {
                    answer = answer + str[i];
                }
            }

            return answer;

        }

    }
}
