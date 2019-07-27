using System;
using System.Linq;

namespace CoderByte
{
    public class Program9 : IProgram
    {
        public void Execute()
        {
            long numOfA = RepeatedString("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 534802106762);
            //long numOfA = RepeatedString("ab", 5);
            //long numOfA = RepeatedString("a", 10);

            Console.WriteLine(" ---- " + numOfA + " Number of A's");
        }

        long RepeatedString(string s, long n)
        {
            long length = s.Length;
            double mod = n % (1.0d * length);
            double repeats = (n - mod) / (1.0d * length);

            // calculate A's for completed sets repeated string
            double aCount = ( s.LongCount(f => (f == 'a')) * repeats);

            // calculate A's in the last remaining set
            aCount += s.Substring(0, (int)mod).Count( f => f== 'a');
            
            return (long) (aCount);
        }
    }
}
