using Xunit;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    public class JumpSearchTests
    {
        [Fact]
        public void Search_ElementFound()
        {
            var js = new JumpSearch();
            int[] arr = { 1, 2, 3, 4, 5 }; //array to search in
            Assert.Equal(2, js.Search(3, arr)); // 3 is at index 2
        }

        [Fact]
        public void Search_ElementNotFound()
        {
            var js = new JumpSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, js.Search(10, arr)); // Not in array
        }

        [Fact]
        public void Search_EmptyArray()
        {
            var js = new JumpSearch();
            int[] arr = { };
            Assert.Equal(-1, js.Search(1, arr)); // Empty array
        }

        [Fact]
        public void Search_FirstElement()
        {
            var js = new JumpSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(0, js.Search(1, arr)); // First element
        }

        [Fact]
        public void Search_LastElement()
        {
            var js = new JumpSearch();
            int[] arr = { 1, 2, 3, 4, 5 };
            Assert.Equal(4, js.Search(5, arr)); // Last element
        }
    }
}