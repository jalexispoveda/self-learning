``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|              Method |          Mean |         Error |        StdDev |        Median | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |--------------:|--------------:|--------------:|--------------:|-----:|------:|------:|------:|----------:|
|   cargarDiccionario |            NA |            NA |            NA |            NA |    ? |     - |     - |     - |         - |
|     cargarHashTable |            NA |            NA |            NA |            NA |    ? |     - |     - |     - |         - |
| findItemDiccionario |      2.961 μs |     0.1847 μs |     0.4736 μs |      3.000 μs |    1 |     - |     - |     - |         - |
|        findItemHash |     60.963 μs |     4.7563 μs |    13.9495 μs |     54.900 μs |    2 |     - |     - |     - |     416 B |
|        findItemList | 29,581.504 μs |   587.5888 μs | 1,213.4727 μs | 29,317.300 μs |    3 |     - |     - |     - |         - |
|         cargarLista | 70,380.600 μs | 1,383.7324 μs | 1,226.6428 μs | 70,178.800 μs |    4 |     - |     - |     - |         - |

Benchmarks with issues:
  BenchmarkExecutorFinal.cargarDiccionario: DefaultJob
  BenchmarkExecutorFinal.cargarHashTable: DefaultJob
