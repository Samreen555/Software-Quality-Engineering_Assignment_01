using Xunit;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    public class LinearSearchTests
    {
        [Fact]
        public void Search_ElementFound()
        {
            var ls = new LinearSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(2, ls.Search(3, arr));
        }

        [Fact]
        public void Search_ElementNotFound()
        {
            var ls = new LinearSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, ls.Search(10, arr));
        }

        [Fact]
        public void Search_EmptyArray()
        {
            var ls = new LinearSearch();
            int[] arr = { };
            Assert.Equal(-1, ls.Search(1, arr));
        }
    }
}