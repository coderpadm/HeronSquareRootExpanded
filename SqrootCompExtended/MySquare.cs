using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrootCompExtended
{
    /// <summary>
    /// Class to compute the square root of a given number using Heron's method.
    /// </summary>
    class MySquare:ISquare 
    {
        /// <summary>
        /// The input number for which square root needs to be computed.
        /// </summary>
        double someNumber;

        /// <summary>
        /// The allowed margin of error in square root computation.
        /// </summary>
       private double marginOfError;
       double ISquare.errorMargin { get { return marginOfError; } }


        /// <summary>
        /// The generated square root output.
        /// </summary>
        public double sqRootResult { get; private set; }

        public MySquare(double num, double error):this(error)
        {
            this.someNumber = num;
          //  this.marginOfError = error * 1;
        }

        public MySquare(double error)
        {
            this.marginOfError = error;
        }


        /// <summary>
        /// Function to perform actual square root computation using Heron's method for positive numbers.
        /// In case of negative numbers, validate and raise an error.
        /// </summary>
        double ISquare.Sqrt()
        {

            if (this.someNumber < 0)
            {
                throw new ArgumentException("The number for which square root needs to be computed cannot be negative");
            }

            double guessNum;

            if (this.someNumber == 0)
            {
                this.sqRootResult = 0;
                return this.sqRootResult;
            }

            if (this.someNumber < 10)
            {
                guessNum = this.someNumber / 4;
            }
            else if (this.someNumber < 100)
            {
                guessNum = this.someNumber / 10;
            }
            else
            {
                guessNum = this.someNumber / 100;
            }

            while (this.sqRootResult == 0)
            {
                double squareGuess = guessNum * guessNum;
                double errorGuess1 = this.marginOfError + squareGuess;
                double errorGuess2 = squareGuess - this.marginOfError;

                if (squareGuess == someNumber)
                {
                    this.sqRootResult = guessNum;
                }
                else if (someNumber > squareGuess && someNumber <= errorGuess1)
                {
                    this.sqRootResult = guessNum;
                }
                else if (someNumber < squareGuess && someNumber >= errorGuess2)
                {
                    this.sqRootResult = guessNum;
                }
                guessNum = (guessNum + (this.someNumber / guessNum)) / 2;

            }

            return this.sqRootResult;

        }

    }
}
