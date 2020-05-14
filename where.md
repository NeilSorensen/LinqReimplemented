# Where

Where does what it sounds like--it filters an Enumerable collection to return only the elements that match the predicate

## Signature

```csharp
public static IEnumerable<TSource> Where(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

## Requirements

* Returns a new enumerable containing the elements of the original where the predicate returns true
  * This should be evaluated lazily
  * Order should be preserved
* Throws an ArgumentNullException if either source or predicate are null
  * This should _NOT_ be evaluated lazily
* The source should not be modified (only enumerated)

## Bonus

There is an overload for where that includes the index of the element:

```csharp
public static IEnumerable<TSource> Where(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
```
