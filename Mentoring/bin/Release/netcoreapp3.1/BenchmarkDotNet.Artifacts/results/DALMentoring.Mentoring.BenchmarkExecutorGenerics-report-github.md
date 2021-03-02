``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|              Method |          Mean |       Error |      StdDev |        Median | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |--------------:|------------:|------------:|--------------:|-----:|------:|------:|------:|----------:|
|   cargarDiccionario |            NA |          NA |          NA |            NA |    ? |     - |     - |     - |         - |
|     cargarHashTable |            NA |          NA |          NA |            NA |    ? |     - |     - |     - |         - |
| findItemDiccionario |      2.368 μs |   0.1682 μs |   0.4312 μs |      2.300 μs |    1 |     - |     - |     - |         - |
|        findItemHash |     58.933 μs |   3.7061 μs |  10.5736 μs |     54.500 μs |    2 |     - |     - |     - |     416 B |
|        findItemList | 27,614.469 μs | 289.1107 μs | 241.4205 μs | 27,633.300 μs |    3 |     - |     - |     - |         - |
|         cargarLista | 65,071.715 μs | 833.2771 μs | 695.8241 μs | 65,076.200 μs |    4 |     - |     - |     - |         - |

Benchmarks with issues:
  BenchmarkExecutorGenerics.cargarDiccionario: DefaultJob
  BenchmarkExecutorGenerics.cargarHashTable: DefaultJob
