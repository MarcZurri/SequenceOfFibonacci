using FibonacciSequence.Core;
using static FibonacciSequence.Core.FibonacciSequenceValidator;

namespace FibonacciSequence.UnitTests;

public class FibonacciSequenceValidatorValidatorTests
{
        #region CalculateSequenceOnFly
        [Fact]
        public void TestIsHalfFibonacci_ExactlyHalf_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // Half are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_MoreThanHalf_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // All are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LessThanHalf_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_EmptyArray_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { }; // Empty array

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_NonFibonacciNumbers_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementFibonacci_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 1 }; // Single Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementNonFibonacci_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4 }; // Single non-Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllFibonacci_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }; // All Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllNonFibonacci_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LargeArray_CalculateSequenceOnFly()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i % 2 == 0 ? 1 : 4; // Half Fibonacci (1), half non-Fibonacci (4)
            }

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFly);

            // Assert
            Assert.True(result);
        }
        #endregion

        #region PreCalculateAllNumbers
        [Fact]
        public void TestIsHalfFibonacci_ExactlyHalf_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // Half are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_MoreThanHalf_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // All are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LessThanHalf_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_EmptyArray_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { }; // Empty array

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_NonFibonacciNumbers_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementFibonacci_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 1 }; // Single Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementNonFibonacci_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4 }; // Single non-Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllFibonacci_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }; // All Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllNonFibonacci_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LargeArray_PreCalculateAllNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i % 2 == 0 ? 1 : 4; // Half Fibonacci (1), half non-Fibonacci (4)
            }

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateAllNumbers);

            // Assert
            Assert.True(result);
        }
        #endregion

        #region PreCalculateHalfNumbers
        [Fact]
        public void TestIsHalfFibonacci_ExactlyHalf_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // Half are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_MoreThanHalf_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // All are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LessThanHalf_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_EmptyArray_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { }; // Empty array

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_NonFibonacciNumbers_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementFibonacci_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 1 }; // Single Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementNonFibonacci_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4 }; // Single non-Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllFibonacci_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }; // All Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllNonFibonacci_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LargeArray_PreCalculateHalfNumbers()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i % 2 == 0 ? 1 : 4; // Half Fibonacci (1), half non-Fibonacci (4)
            }

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.PreCalculateHalfNumbers);

            // Assert
            Assert.True(result);
        }
        #endregion

        #region CalculateSequenceOnFlyFromLastNumber
        [Fact]
        public void TestIsHalfFibonacci_ExactlyHalf_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // Half are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_MoreThanHalf_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // All are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LessThanHalf_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_EmptyArray_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { }; // Empty array

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_NonFibonacciNumbers_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementFibonacci_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 1 }; // Single Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementNonFibonacci_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4 }; // Single non-Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllFibonacci_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }; // All Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllNonFibonacci_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LargeArray_CalculateSequenceOnFlyFromLastNumber()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i % 2 == 0 ? 1 : 4; // Half Fibonacci (1), half non-Fibonacci (4)
            }

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.CalculateSequenceOnFlyFromLastNumber);

            // Assert
            Assert.True(result);
        }
        #endregion
    
        #region IterateSequence
        [Fact]
        public void TestIsHalfFibonacci_ExactlyHalf_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // Half are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_MoreThanHalf_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5 }; // All are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LessThanHalf_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_EmptyArray_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { }; // Empty array

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_NonFibonacciNumbers_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementFibonacci_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 1 }; // Single Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_SingleElementNonFibonacci_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4 }; // Single non-Fibonacci number

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllFibonacci_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }; // All Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_AllNonFibonacci_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = { 4, 6, 7, 10, 11, 14 }; // None are Fibonacci numbers

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsHalfFibonacci_LargeArray_IterateSequence()
        {
            // Arrange
            FibonacciSequenceValidator fibonacciSequenceValidator = new FibonacciSequenceValidator();
            int[] numbers = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                numbers[i] = i % 2 == 0 ? 1 : 4; // Half Fibonacci (1), half non-Fibonacci (4)
            }

            // Act
            bool result = fibonacciSequenceValidator.IsHalfFibonacci(numbers, CalculationType.IterateSequence);

            // Assert
            Assert.True(result);
        }
        #endregion

}