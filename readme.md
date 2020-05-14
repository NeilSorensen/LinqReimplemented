# Reimplementing LINQ

This exercise follows Jon Skeet's set of [blog posts](https://codeblog.jonskeet.uk/category/Edulinq/) on re-implementing linq.

## Understanding `yield return`

`yield return` is the construct that C# uses for lazy evaluation.
The return type of a method that has a `yield return` must be either `IEnumerable<T>` or `IEnumerable`.
Typically, `yield return` is used in a `foreach` block, but you can also use a succession of `yield return` statements to create an `IEnumerable` that lazily generates items.

## The methods

This is an incomplete list of LINQ methods.
Each one includes a description of the requirements that need to be tested to prove that your implementation adheres to the documented behavior

* [Where](where.md)
* [Select](select.md)
* [Range](range.md)
* [Aggregate](aggregate.md)
* [Distinct](distinct.md)
* [GroupBy](groupby.md)
* [Zip](zip.md)
