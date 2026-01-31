using System.Numerics;

namespace MathLib
{
    /// <summary>
    /// Provides basic mathematical utility operations.
    /// Compiled as MathLib.dll — packaged as a dependency in the MSI installer.
    /// </summary>
    public static class MathOperations
    {
        // O(1) Lookup table for factorial performance in common cases (0-20)
        private static readonly System.Numerics.BigInteger[] SmallFactorials = {
            1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600,
            6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000,
            6402373705728000, 121645100408832000, 2432902008176640000
        };

        /// <summary>
        /// Returns the sum of two integers.
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Returns the product of two integers.
        /// </summary>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Returns the factorial of a non-negative integer with Parallel Binary Splitting to optimize memory and multicore performance.
        /// Throws ArgumentOutOfRangeException if n is negative.
        /// </summary>
        public static System.Numerics.BigInteger Factorial(int n)
        {
            if (n < 0) throw new System.ArgumentOutOfRangeException(nameof(n), "Factorial is undefined for negative numbers.");
            if (n <= 20) return SmallFactorials[n];

            // Use a threshold to decide when to use multiple CPU cores
            // Parallelization has overhead; for smaller n, sequential is faster
            return MultiplyRange(1, n, useParallel: n > 10000);
        }

        private static System.Numerics.BigInteger MultiplyRange(int start, int end, bool useParallel)
        {
            if (start > end) return 1;
            if (start == end) return new BigInteger(start);

            // Base case: small range multiplication is faster sequentially
            if (end - start <= 64)
            {
                BigInteger res = start;
                for (int i = start + 1; i <= end; i++) res *= i;
                return res;
            }

            int mid = start + (end - start) / 2;

            if (useParallel)
            {
                BigInteger left = 0;
                BigInteger right = 0;

                Parallel.Invoke(
                    () => left = MultiplyRange(start, mid, useParallel: (mid - start) > 5000),
                    () => right = MultiplyRange(mid + 1, end, useParallel: (end - (mid + 1)) > 5000)
                );

                return left * right;
            }
            else
            {
                return MultiplyRange(start, mid, false) * MultiplyRange(mid + 1, end, false);
            }
        }

        /// <summary>
        /// Returns the greatest common divisor of two positive integers with Euclid's algorithm.
        /// </summary>
        public static int GCD(int a, int b)
        {
            a = System.Math.Abs(a);
            b = System.Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        /// <summary>
        /// Returns the version string of this library (for demonstration in the UI).
        /// </summary>
        public static string GetLibraryInfo()
        {
            return "MathLib v1.0.0";
        }
    }
}