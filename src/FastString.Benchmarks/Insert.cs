using System;
using BenchmarkDotNet.Attributes;
using FastStringUtility.Extensions;

namespace FastStringUtility.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class Insert
    {
        int startIndex;
        string source;
        string value;

        [GlobalSetup]
        public void Setup()
        {
            startIndex = new Random().Next(1, 30);
            source = GetString();
            value = GetString();

            static string GetString() => Guid.NewGuid().ToString();
        }

        [Benchmark]
        public string StringInsert()
            => source.Insert(startIndex, value);

        [Benchmark]
        public string FastStringInsert()
            => source.AsSpan().Insert(startIndex, value);
    }
}
