# Reimplementing LINQ

This exercise follows Jon Skeet's set of [blog posts](https://codeblog.jonskeet.uk/category/Edulinq/) on re-implementing linq.

## Understanding `yield return`

`yield return` is the construct that C# uses for lazy evaluation.
The return type of a method that has a `yield return` must be either `IEnumerable<T>` or `IEnumerable`.
Typically, `yield return` is used in a `foreach` block, but you can also use a succession of `yield return` statements to create an `IEnumerable` that lazily generates items.

An important note is that a method is either evaluated lazily or immediately.
If a method contains `yield return`, then none of the code is executed until the first enumeration.
This means that if some things are supposed to be evaluated immediately, you'll need to put them in a seperate method.

## Testing for lazy evaluation

One of the important characteristics of many LINQ methods is lazy evaluation.
To enable you to write tests that verify that your implementation correctly implements lazy evaluation, the C# code includes a TestHelper with a static `AssertDeferred` method.

## The methods

This is an incomplete list of LINQ methods.
Each one includes a description of the requirements that need to be tested to prove that your implementation adheres to the documented behavior

* [Where](where.md)
* [Select](select.md)
* [Range](range.md)
* [Aggregate](aggregate.md)
* [Distinct](distinct.md)
* [Zip](zip.md)
