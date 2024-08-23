using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using FibonacciSequence.Core;

namespace FibonacciSequence.Benchmark
{
    public class FibonacciSequenceValidatorBenchmark
    {
        private readonly FibonacciSequenceValidator _fibonacciSequenceValidator = new FibonacciSequenceValidator();
        private int[] _largeArray;

        public FibonacciSequenceValidatorBenchmark()
        {
            this.SetLargeArrayNumbers();
        }

        // Set a 5000 numbers array a third part of them are Fibonacci numbers
        private void SetLargeArrayNumbers()
        {
            this._largeArray = new int[5000];
            int fibonacciFirstNumber = 1, fibonacciSecondNumber = 1;
            int totalNumbers = this._largeArray.Length;
            for (int i = 0; i < totalNumbers; i++)
            {
                int nextFibonacciNumber = fibonacciFirstNumber + fibonacciSecondNumber;

                if (nextFibonacciNumber < fibonacciSecondNumber || nextFibonacciNumber > int.MaxValue)
                {
                    fibonacciFirstNumber = 1;
                    fibonacciSecondNumber = 1;
                    nextFibonacciNumber = fibonacciFirstNumber + fibonacciSecondNumber;
                }

                int number = RandomNumberGenerator.GetInt32(fibonacciSecondNumber, nextFibonacciNumber);

                if (i >= 3 && i % 3 == 0)
                {
                    this._largeArray[i] = nextFibonacciNumber;
                    fibonacciFirstNumber = fibonacciSecondNumber;
                    fibonacciSecondNumber = nextFibonacciNumber;
                }                   
                else
                    this._largeArray[i] = number;
            }

            this._largeArray = this._largeArray.Order().ToArray();  
        }

        [Benchmark]
        public void BenchmarkIsHalfFibonacci_CalculateSequenceOnFly()
        {
            this._fibonacciSequenceValidator.IsHalfFibonacci(this._largeArray, FibonacciSequenceValidator.CalculationType.CalculateSequenceOnFly);
        }

        [Benchmark]
        public void BenchmarkIsHalfFibonacci_PreCalculateAllNumbers()
        {
            this._fibonacciSequenceValidator.IsHalfFibonacci(this._largeArray, FibonacciSequenceValidator.CalculationType.PreCalculateAllNumbers);
        }

        [Benchmark]
        public void BenchmarkIsHalfFibonacci_PreCalculateHalfNumbers()
        {
            this._fibonacciSequenceValidator.IsHalfFibonacci(this._largeArray, FibonacciSequenceValidator.CalculationType.PreCalculateHalfNumbers);
        }

        [Benchmark]
        public void BenchmarkIsHalfFibonacci_CalculateSequenceOnFlyFromLastNumber()
        {
            this._fibonacciSequenceValidator.IsHalfFibonacci(this._largeArray, FibonacciSequenceValidator.CalculationType.CalculateSequenceOnFlyFromLastNumber);
        }

        [Benchmark]
        public void BenchmarkIsHalfFibonacci_IterateSequence()
        {
            this._fibonacciSequenceValidator.IsHalfFibonacci(this._largeArray, FibonacciSequenceValidator.CalculationType.IterateSequence);
        }
}

}
