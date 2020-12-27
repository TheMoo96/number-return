using System;

namespace number_return
{
    public class NumberReturn
    {
        int _Multiplier;
        int _Key;
        public double Result;
        public NumberReturn()
        {
            _Multiplier = DateTime.Now.Millisecond;
        }

        public double GetRandom()
        {
            _Key = DateTime.Now.Millisecond;
            Result = Math.Sqrt(_Key * _Multiplier);
            return Result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberReturn ran1 = new NumberReturn();

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                double DubRan = ran1.GetRandom();
                int IntRan = Convert.ToInt32(ran1.GetRandom());
                Console.WriteLine($"This is a double {DubRan}");
                Console.WriteLine($"This is an int {IntRan}");
            }

            //for (int i = 1; i < 16; i++)
            //{
            //    Console.WriteLine(DateTime.Now.Millisecond);
            //}
        }
    }
}
