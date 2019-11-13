using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;

namespace FastStringUtility.Benchmarks
{
    class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            Add(MarkdownExporter.GitHub);
            Add(MemoryDiagnoser.Default);
            Add(BenchmarkLogicalGroupRule.ByCategory);
            Add(CategoriesColumn.Default);
            Add(Job.Default.With(CsProjCoreToolchain.NetCoreApp30));
        }
    }
}