``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|                  Method |      Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |----------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|    FindItemForeachArray |  61.24 ms | 0.645 ms | 0.572 ms |    1 |     - |     - |     - |         - |
|        FindItemForArray |  61.39 ms | 0.999 ms | 0.834 ms |    1 |     - |     - |     - |         - |
| getArrayListItemIndexOf |  72.60 ms | 1.371 ms | 1.216 ms |    2 |     - |     - |     - |         - |
|        FindItemLinqList |  73.67 ms | 1.086 ms | 1.016 ms |    2 |     - |     - |     - |      88 B |
|         FindItemForList |  94.77 ms | 1.134 ms | 0.947 ms |    3 |     - |     - |     - |         - |
|        getArrayListItem | 127.41 ms | 1.535 ms | 1.436 ms |    4 |     - |     - |     - |      48 B |
|  getArrayListItemEquals | 129.95 ms | 1.359 ms | 1.205 ms |    5 |     - |     - |     - |      48 B |
