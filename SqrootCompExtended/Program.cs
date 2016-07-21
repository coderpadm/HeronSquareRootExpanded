using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrootCompExtended
{
    class Program
    {

        private static void compSqRoot(double number)
        {
            try
            {

                double acceptableError = 0.0001;

                HeronSqroot hs = new HeronSqroot(number, acceptableError);
                TradSqroot ts = new TradSqroot(number);
                hs.computeSqroot();
                ts.computeSqroot();
                Console.WriteLine("Heron Squareroot: " + hs.sqRootResult);
                Console.WriteLine("Traditional Squareroot: " + ts.sqrootNum);

                double degError = Math.Abs(hs.sqRootResult - ts.sqrootNum);
                Console.WriteLine("Degree of Error: " + degError);

                if (degError <= acceptableError)
                {
                    Console.WriteLine("The square root computation for {0} is within the acceptable error range.", number);
                }
                else
                {
                    throw new FormatException("Error in square root computation");
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        static void Main(string[] args)
        {


            //     int countMax = 10000;
            int countMax = 100;
            int minRange = 0, maxRange = 100000;
            Random rand = new Random();
            int count;

            for (int k = 0; k < countMax; k++)
            {
                count = k + 1;
                Console.Write(count + ") ");
                IndivSqRoot(minRange, maxRange, rand);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void IndivSqRoot(int minRange, int maxRange, Random rand)
        {
            try
            {
                double num = (double)rand.Next(minRange, maxRange);
                Console.WriteLine(num);
                compSqRoot(num);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}
