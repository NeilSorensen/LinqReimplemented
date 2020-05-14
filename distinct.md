# Distinct

Distinct returns a sequence that contains only the unique elements of the source

## Signature

```csharp
public static IEnumerable<TSource> Distinct<TSource>(
    this IEnumerable<TSource> source)
```

## Requirements

* The result should be evaluated lazily
* This behavior is undocumented, but please test:
  * The result sequence should be in the same order as the input sequence
  * When multiple instances of an item are present, the first instance should be returned.