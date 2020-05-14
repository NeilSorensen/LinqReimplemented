# Zip

Zip is an operator that was borrowed from python.
It takes two source sequences and returns a new sequence that combines the elements in the same position in the source sequences.
You can think of this like closing a zipper, hence the name.

## Signature

```csharp
public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
    this IEnumerable<TFirst> first,
    IEnumerable<TSecond> second,
    Func<TFirst, TSecond, TResult> resultSelector)
```

## Requirements

* Both sequences should be iterated at the same time - no buffering
* When either sequence terminates, zip terminates
* Arguments should be validated immediately (none of them can be null)
* Results should be evaluated lazily