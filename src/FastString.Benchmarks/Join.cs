using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace FastStringUtility.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class Join
    {
        char separator;
        string str0;
        string str1;

        [GlobalSetup]
        public void Setup()
        {
            separator = GetString().First();
            str0 = GetString();
            str1 = GetString();

            static string GetString() => Guid.NewGuid().ToString();
        }

        [Benchmark]
        public string StringJoin()
            => string.Join(separator, str0, str1);

        [Benchmark]
        public string FastStringConcat()
            => FastString.Join(separator, str0, str1);
    }
}