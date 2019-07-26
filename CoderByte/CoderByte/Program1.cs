using System;
namespace CoderByte
{
    /**
     * Have the function LetterChanges(str) take the str parameter being passed and modify it using the following algorithm.
     * Replace every letter in the string with the letter following it in the alphabet
     * (ie. c becomes d, z becomes a).
     * Then capitalize every vowel in this new string (a, e, i, o, u)
     * and finally return this modified string. 
     *
     *
     *   --Sample Test Cases--
     * 
     *   Input:"hello*3"
     *   Output:Ifmmp*3
     *
     *   Input:"fun times!"
     *   Output:gvO Ujnft!
     *
     */
    public class Program1 : IProgram
    {
        public void Execute()
        {
            Console.WriteLine(LetterChanges("hello*3"));
            Console.WriteLine(LetterChanges("fun times!"));
        }

        public string LetterChanges(string str)
        {

            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            string answer = "";

            int length = str.Length - 1;
            int i = 0;

            while (length >= 0)
            {

                int index = Array.IndexOf(alphabets, Char.ToLower(str[i]));
                if (index >= 0)
                {
                    char next = alphabets[index + 1];
                    if (-1 != Array.IndexOf(vowel, Char.ToLower(next)))
                    {
                        next = Char.ToUpper(next);
                    }
                    answer = answer + next;

                }
                else
                {
                    answer = answer + str[i];
                }

                length--;
                i++;
            }

            return answer;

        }
    }
}
