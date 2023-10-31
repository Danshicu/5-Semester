using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Laba4{

    public static class SecretGenerator
    {
        public static bool IsPrimitive(int primitive, int primary)
        {
            List<float> remainders = new List<float>();
            for (int i = 1; i < primary; i++)
            {
                var remainder = ModulusPow(primitive, i, primary);
                if (remainders.Contains(remainder))
                {
                    return false;
                }

                remainders.Add(remainder);
            }
            return true;
        }

        public static int ModulusPow(int powBase, int exponent, int mod = 1)
        {
            if (exponent == 0)
            {
                return 1;
            }
            int result = 1;
            while (exponent != 0)
            {
                if (exponent % 2 != 0)
                {
                    result *= powBase;
                    result %= mod;
                    exponent -= 1;
                }
                else
                {
                    powBase *= powBase;
                    powBase %= mod;
                    exponent /= 2;
                }
            }
            return result;
        }

        public static int FindPrimitive(int primary)
        {
            for (int i = 2; i < primary; i++)
            {
                if (IsPrimitive(i, primary)) return i;
            }

            return -1;
        }

        public static int GenerateSharedKey(int primary, int primitive, int firstKey, int secondKey)
        {
            var sharedSecret = ModulusPow(primitive, firstKey * secondKey, primary);
            var firstOpen = ModulusPow(primitive, firstKey, primary);
            var secondOpen = ModulusPow(primitive, secondKey, primary);
            if (ModulusPow(firstOpen, secondOpen, primary) != ModulusPow(secondOpen, firstOpen, primary))
            {
                Console.WriteLine("Shared keys are not the same");
            }

            return sharedSecret;
        }
    }
}