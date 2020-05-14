# Select

Select transforms a sequence of items by applying a selector to each item

## Signature

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(
    this IEnumerable<TSource> source,
    Func<TSource, TResult> selector)
```

## Requirements

* The input sequence should not be modified (only enumerated once)
* Returns a sequence where each item has been projected
  * This should be evaluated lazily
  * Order should be preserved
* Throws an ArgumentNullException if either source or selector are null
  * This should _NOT_ be evaluated lazily

## Bonus

There is an overload for where that includes the index of the element:

```csharp
public static IEnumerable<TResult> Select<TSource, TResult>(
    this IEnumerable<TSource> source,
    Func<TSource, int, TResult> selector)
```