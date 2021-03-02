``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|                     Method |     Mean |    Error |    StdDev |   Median | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |---------:|---------:|----------:|---------:|-----:|------:|------:|------:|----------:|
|     GetUserQueryableEquals | 25.95 μs | 1.152 μs |  3.074 μs | 24.60 μs |    1 |     - |     - |     - |   3.34 KB |
| GetUserEnumerableNotEquals | 28.32 μs | 1.262 μs |  3.539 μs | 26.40 μs |    2 |     - |     - |     - |   3.07 KB |
|    GetUserEnumerableEquals | 40.25 μs | 5.976 μs | 17.051 μs | 32.65 μs |    3 |     - |     - |     - |   3.16 KB |
|  GetUserQueryableNotEquals | 70.07 μs | 8.002 μs | 22.570 μs | 72.35 μs |    4 |     - |     - |     - |   3.25 KB |
