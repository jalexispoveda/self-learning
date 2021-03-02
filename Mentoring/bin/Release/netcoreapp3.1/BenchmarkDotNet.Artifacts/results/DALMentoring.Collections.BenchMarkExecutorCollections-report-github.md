``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT


```
|                        Method |      Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |----------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|              FindItemForArray |  59.56 ms | 0.303 ms | 0.268 ms |    1 |     - |     - |     - |         - |
|          FindItemForeachArray |  60.30 ms | 0.481 ms | 0.450 ms |    1 |     - |     - |     - |         - |
|              FindItemLinqList |  72.90 ms | 0.311 ms | 0.275 ms |    2 |     - |     - |     - |      88 B |
| FindItemArrayListUsingIndexOf |  74.86 ms | 1.407 ms | 2.148 ms |    2 |     - |     - |     - |         - |
|           FindItemForeachList |  92.54 ms | 0.670 ms | 0.559 ms |    3 |     - |     - |     - |         - |
|             FindItemArrayList | 128.89 ms | 1.887 ms | 2.707 ms |    4 |     - |     - |     - |      48 B |
|  FindItemArrayListUsingEquals | 132.40 ms | 2.087 ms | 1.850 ms |    5 |     - |     - |     - |      48 B |
