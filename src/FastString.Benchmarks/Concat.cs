using System;
using BenchmarkDotNet.Attributes;

namespace FastStringUtility.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class Concat
    {
        string str0;
        string str1;

        [GlobalSetup]
        public void Setup()
        {
            str0 = GetString();
            str1 = GetString();

            static string GetString() => Guid.NewGuid().ToString();
        }

        [Benchmark]
        public string StringConcat()
            => string.Concat(str0, str1);

        [Benchmark]
        public string StringConcatSpan()
            => string.Concat(str0.AsSpan(), str1.AsSpan());

        [Benchmark]
        public string FastStringConcat()
            => FastString.Concat(str0, str1);
    }
}