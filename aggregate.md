# Aggregate

Aggregate combines all elements of a an input sequence into a single value.
There is also an overload that allows for a final projection, if the type that you accumulate is not the final type you need.

In functional programming terms, Aggregate is considered a `Left Fold`

## Signature

```csharp
public static TSource Aggregate<TSource>(
    this IEnumerable<TSource> source,
    Func<TSource, TSource, TSource> func);

public static TAccumulate Aggregate<TSource, TAccumulate>(
    this IEnumerable<TSource> source,
    TAccumulate seed,
    Func<TAccumulate, TSource, TAccumulate> func);
```

## Requirements

* Result should be evaluated immediately
* If `seed` is not provided (the first signature), the first element of the sequence should be used as the seed.
  * This means `source` can _NOT_ be empty if the first signature is used
* Arguments should be evaluated before starting accumulation
  * `source` and `func` cannot be null

## Bonus

There is a third signature that applies a final projection:

```csharp
public static TResult Aggregate<TSource, TAccumulate, TResult>(
    this IEnumerable<TSource> source,
    TAccumulate seed,
    Func<TAccumulate, TSource, TAccumulate> func,
    Func<TAccumulate, TResult> resultSelector)
```

You should be able to implement the second overload by calling the third with an identity resultSelector (`x => x`).