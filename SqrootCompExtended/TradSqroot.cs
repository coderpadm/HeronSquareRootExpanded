using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrootCompExtended
{
    class TradSqroot 
    {
        /// <summary>
        /// Number for which square root needs to be computed.
        /// </summary>
        double number;

        /// <summary>
        /// The output after square root computation
        /// </summary>
        public double sqrootNum { get; private set; }

        /// <summary>
        /// Constructor that accepts the input number
        /// </summary>
        /// <param name="num"></param>
        public TradSqroot(double num)
        {
            this.number = num;
        }

        /// <summary>
        /// Method to perform square root computation using Math library for positive numbers.
        /// In case of negative numbers, validate the input and raise an error.
        /// </summary>
        public void computeSqroot()
        {
            try
            {
                if (this.number < 0)
                {
                    throw new ArgumentException("The number for which square root needs to be computed cannot be negative");
                }

                this.sqrootNum = Math.Sqrt(this.number);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.ParamName);
            }

        }
    }
}
