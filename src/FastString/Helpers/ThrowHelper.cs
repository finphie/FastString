using System;
using System.Diagnostics.CodeAnalysis;

namespace FastStringUtility.Helpers
{
    static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowArgumentOutOfRangeException(string paramName)
            => throw new ArgumentOutOfRangeException(paramName);
    }
}