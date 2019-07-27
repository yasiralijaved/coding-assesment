using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CoderByte
{
    public class Program9 : IProgram
    {
        public void Execute()
        {
            long numOfA = RepeatedString("a", 1000000000000);
            //long numOfA = RepeatedString("ab", 5);
            //long numOfA = RepeatedString("a", 10);

            Console.WriteLine(" ---- " + numOfA + " Number of A's");
        }

        long RepeatedString(string s, long n)
        {
            
            //string result = s;
            //long lengthInitial = s.Length;
            //long remainingLetters = n - lengthInitial;
            //long iterationsRequired = (long)Math.Ceiling((decimal)(remainingLetters / (lengthInitial * 1.0f))) - 1;

            //double aCount = result.Count(f => (f == 'a') || (f == 'A'));


            long length = s.Length;
            double itReq = n / (1.0d * length);
            double mod = n % (1.0d * length);

            // calculate A's for completed sets repeated string
            double aCount = ( s.LongCount(f => (f == 'a')) * itReq);

            // calculate A's in the last remaining set
            aCount += s.Substring(0, (int)mod).Count( f => f== 'a');


            //string test = RepeatStringBuilderAppend(result, (int)iterationsRequired);

            //int aCount = test.Count(f => (f == 'a') || (f == 'A'));
            //Console.Write(result);
            //for (int i = 0; i <= iterationsRequired; i++)
            //{
            //    if(i == iterationsRequired)
            //    {
            //        string subStr = s;

            //        int extraLettersCount = (int)(result.Length - n + s.Length);
            //        if (extraLettersCount > 0)
            //        {
            //            subStr = s.Substring(0, s.Length - extraLettersCount);                        
            //        }
            //        result += subStr;
            //        aCount += subStr.Count(f => (f == 'a') || (f == 'A'));
            //        //Console.Write(" " + subStr);
            //    }
            //    else
            //    {
            //        result += s;
            //        aCount += s.Count(f => (f == 'a') || (f == 'A'));
            //        //Console.Write(" " + s);
            //    }
            //}

            return (long) (aCount);
        }

        string RepeatStringBuilderAppend(string s, int n)
        {
            return new StringBuilder(n)
                        .AppendJoin(s, new string[n + 1])
                        .ToString();
        }
    }
}
