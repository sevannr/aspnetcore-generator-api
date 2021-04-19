using api.Controllers;
using System.Linq;
using Xunit;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void CountShouldControlNumberOfResults()
        {
            Range range = new Range { Count = 3 };

            System.Collections.Generic.IEnumerable<string> generated = range.Of(() => "");

            Assert.Equal(3, generated.Count());
        }

        [Fact]
        public void SortShouldOrderResults()
        {
            var range = new Range { Count = 3, Sort = true };
            var values = new[] { "a", "c", "b" };
            var counter = 0;
            var generated = range.Of(() => values[counter++]);

            Assert.Equal(new[] { "a", "b", "c" }, generated.ToArray());
        }
    }
}
