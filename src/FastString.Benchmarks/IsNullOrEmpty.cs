using System;
using BenchmarkDotNet.Attributes;

namespace FastStringUtility.Benchmarks
{
    public class IsNullOrEmpty
    {
        string value;

        [GlobalSetup]
        public void Setup()
            => value = Guid.NewGuid().ToString();

        [Benchmark]
        public bool StringIsNullOrEmpty()
            => string.IsNullOrEmpty(value);

        [Benchmark]
        public bool FastStringIsNullOrEmpty()
            => FastString.IsNullOrEmpty(value);
    }
}