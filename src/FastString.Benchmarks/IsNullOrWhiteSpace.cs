using System;
using BenchmarkDotNet.Attributes;

namespace FastStringUtility.Benchmarks
{
    public class IsNullOrWhiteSpace
    {
        string value;

        [GlobalSetup]
        public void Setup()
            => value = Guid.NewGuid().ToString();

        [Benchmark]
        public bool StringIsNullOrEmpty()
            => string.IsNullOrWhiteSpace(value);

        [Benchmark]
        public bool FastStringIsNullOrEmpty()
            => FastString.IsNullOrWhiteSpace(value);
    }
}