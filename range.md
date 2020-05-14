# Range

Range builds an `IEnumerable<int>` starting from a given integer

This is a simple static method, instead of an extension method. 
Don't worry about trying to conflict with `Enumerable`, just put it somewhere easy to test.

## Signature

```csharp
public static IEnumerable<int> Range(
    int start,
    int count)
```

## Requirements

* The arguments should be evaluated for safety eagerly
  * Count cannot be negative
  * The range should not overflow `Int.MaxValue`
* The result should be evaluated lazily