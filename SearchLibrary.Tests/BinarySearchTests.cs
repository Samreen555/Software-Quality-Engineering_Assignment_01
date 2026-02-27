using Xunit;
using SearchLibrary; 

namespace SearchLibrary.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void Search_ElementFound()
        {
            var bs = new BinarySearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(2, bs.Search(3, arr)); // 3 is at index 2
        }

        [Fact]
        public void Search_ElementNotFound()
        {
            var bs = new BinarySearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, bs.Search(10, arr)); // Element not in array
        }

        [Fact]
        public void Search_EmptyArray()
        {
            var bs = new BinarySearch();
            int[] arr = { };
            Assert.Equal(-1, bs.Search(1, arr)); // Empty array
        }

        [Fact]
        public void Search_FirstElement()
        {
            var bs = new BinarySearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(0, bs.Search(1, arr)); // First element
        }

        [Fact]
        public void Search_LastElement()
        {
            var bs = new BinarySearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(4, bs.Search(5, arr)); // Last element
        }

    }
}