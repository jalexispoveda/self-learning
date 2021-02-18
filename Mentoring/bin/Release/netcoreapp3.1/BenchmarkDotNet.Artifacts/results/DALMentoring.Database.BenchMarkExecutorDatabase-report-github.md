``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1316 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|                     Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|     GetUserQueryableEquals | 57.32 μs | 4.530 μs | 12.92 μs |    1 |     - |     - |     - |   3.34 KB |
| GetUserEnumerableNotEquals | 58.37 μs | 5.398 μs | 15.14 μs |    1 |     - |     - |     - |   3.07 KB |
|    GetUserEnumerableEquals | 59.30 μs | 6.728 μs | 18.98 μs |    1 |     - |     - |     - |   3.16 KB |
|  GetUserQueryableNotEquals | 63.10 μs | 6.819 μs | 19.56 μs |    1 |     - |     - |     - |   3.25 KB |
