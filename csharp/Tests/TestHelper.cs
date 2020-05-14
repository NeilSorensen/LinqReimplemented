using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace LinqReimplemented.Tests 
{
    /// <summary>
    /// Class to help for deferred execution tests: it throw an exception
    /// if GetEnumerator is called.
    /// </summary>
    public class ThrowingEnumerable<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new InvalidOperationException("Execution was not deferred");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class TestHelper 
    {
        /// <summary>
        /// Asserts that a function is executed lazily
        /// </summary>
        /// <param name="deferredFunction">
        /// A predicate that invokes the function that should be evaluated lazily
        /// </param>
        /// <example>
        /// The following would test that the `where` function is executed lazily
        /// <code>
        /// TestHelper.AssertDeferred<int>(source => source.Where(x => x > 5));
        /// </code>
        /// </example>
        public static void AssertDeferred<T>(
            Func<IEnumerable<T>, IEnumerable<T>> deferredFunction)
        {
            ThrowingEnumerable<T> source = new ThrowingEnumerable<T>();
            var result = deferredFunction(source);
            using (var iterator = result.GetEnumerator())
            {
                Assert.Throws<InvalidOperationException>(() => iterator.MoveNext());
            }
        }
    }

}