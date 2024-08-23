namespace FibonacciSequence.Core
{
    public class FibonacciSequenceValidator
    {
        public enum CalculationType
        {
            CalculateSequenceOnFly,
            PreCalculateAllNumbers,
            PreCalculateHalfNumbers,
            CalculateSequenceOnFlyFromLastNumber,
            IterateSequence,
        }

        // Calculate if the 50% of the given numbers in an array are in the whole fibonacci sequence
        public bool IsHalfFibonacci(int[] numbers, CalculationType calculationType)
        {   
            if (numbers == null || numbers.Length == 0)
                return false;

            // numbers = numbers.Order().ToArray();

            int totalNumbers = numbers.Length;
            int half = (totalNumbers + 1) / 2;

            switch (calculationType)
            {
                case CalculationType.CalculateSequenceOnFly:
                    return IsHalfInFibonacciCalculateSequenceOnFly(numbers, totalNumbers, half);
                case CalculationType.PreCalculateAllNumbers:
                    return IsHalfInFibonacciPrecalculateTotalNumbers(numbers, totalNumbers, half);
                case CalculationType.PreCalculateHalfNumbers:
                    return IsHalfInFibonacciPrecalculateHalfNumbers(numbers, totalNumbers, half);
                case CalculationType.CalculateSequenceOnFlyFromLastNumber:
                    return IsHalfInFibonacciCalculateSequenceOnFlyFromLastNumber(numbers, totalNumbers, half);
                case CalculationType.IterateSequence:
                    return IsHalfInFibonacciIterateSequence(numbers, totalNumbers, half);
                default:
                    throw new ArgumentException("Invalid CalculationType");
            }
        }

        public bool IsHalfInFibonacciCalculateSequenceOnFly(int[] numbers, int totalNumbers, int half)
        {
            int count = 0;
            for (int i = 0; i < totalNumbers; i++)
            {
                if (numbers[i] == 0 || numbers[i] == 1)
                    count++;
                else
                {
                    int a = 0;
                    int b = 1;
                    int c = 0;
                    while (c < numbers[i])
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    if (c == numbers[i])
                        count++;
                }

                if(count >= half)
                    break;
            }
            return count >= half;
        }

        public bool IsHalfInFibonacciPrecalculateTotalNumbers(int[] numbers, int totalNumbers, int half)
        {
            // Find the maximum number in the array to limit Fibonacci calculation
            int maxNumber = numbers.Max();

            // Precompute Fibonacci numbers up to the maximum number in the array
            var fibonacciNumbers = new HashSet<int> { 0, 1 };
            int a = 0, b = 1;
            while (b <= maxNumber)
            {
                int c = a + b;
                fibonacciNumbers.Add(c);
                a = b;
                b = c;
            }

            int count = 0;
            for (int i = 0; i < totalNumbers; i++)
            {
                if (fibonacciNumbers.Contains(numbers[i]))
                    count++;

                if (count >= half)
                    break;
            }

            return count >= half;
        }

        public bool IsHalfInFibonacciPrecalculateHalfNumbers(int[] numbers, int totalNumbers, int half)
        {
            int halfIndex = (totalNumbers + 1) / 2;

            // Find the maximum number in the first half of the array to limit Fibonacci calculation
            int maxNumberFirstHalf = numbers.Take(halfIndex).Max();

            // Precompute Fibonacci numbers up to the maximum number in the first half of the array
            var fibonacciNumbers = new HashSet<int> { 0, 1 };
            int a = 0, b = 1;
            while (b <= maxNumberFirstHalf)
            {
                int c = a + b;
                fibonacciNumbers.Add(c);
                a = b;
                b = c;
            }

            int count = 0;

            // Check the first half of the numbers
            for (int i = 0; i < halfIndex; i++)
            {
                if (fibonacciNumbers.Contains(numbers[i]))
                    count++;

                if (count >= half)
                    return true;
            }

            // If not enough Fibonacci numbers in the first half, check the remaining numbers
            for (int i = halfIndex; i < totalNumbers; i++)
            {
                // Calculate more Fibonacci numbers if needed
                while (b <= numbers[i])
                {
                    int c = a + b;
                    fibonacciNumbers.Add(c);
                    a = b;
                    b = c;
                }

                if (fibonacciNumbers.Contains(numbers[i]))
                    count++;

                if (count >= half)
                    return true;
            }

            return count >= half;
        }

        public bool IsHalfInFibonacciCalculateSequenceOnFlyFromLastNumber(int[] numbers, int totalNumbers, int half)
        {
            int lastCalculatedNumber1 = 0;
            int lastCalculatedNumber2 = 1;

            int count = 0;
            for (int i = 0; i < totalNumbers; i++)
            {
                if (numbers[i] == 0 || numbers[i] == 1)
                    count++;
                else
                {
                    int a = lastCalculatedNumber1;
                    int b = lastCalculatedNumber2;
                    int c = b;
                    while (c < numbers[i])
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }

                    lastCalculatedNumber1 = a;
                    lastCalculatedNumber2 = b;

                    if (c == numbers[i])
                        count++;
                }

                if(count >= half)
                    break;
            }
            return count >= half;
        }

        public bool IsHalfInFibonacciIterateSequence(int[] numbers, int totalNumbers, int half)
        {
            int count = 0;
            int maxFibonacciNumber = numbers.Max();

            int fibonacciFirstNumber = 0, fibonacciSecondNumber = 1;
            int nextFibonacciNumber = 0;

            while (nextFibonacciNumber <= maxFibonacciNumber)
            {
                if (fibonacciFirstNumber == 0 || (fibonacciFirstNumber == 1 && fibonacciSecondNumber == 1))
                    count = count + numbers.Count(n=> n == fibonacciFirstNumber);
                else
                    count = count + numbers.Count(n=> n == nextFibonacciNumber);

                nextFibonacciNumber = fibonacciFirstNumber + fibonacciSecondNumber;
                fibonacciFirstNumber = fibonacciSecondNumber;
                fibonacciSecondNumber = nextFibonacciNumber;

                if(count >= half)
                    break;
            }

            return count >= half;
        }
    }
}