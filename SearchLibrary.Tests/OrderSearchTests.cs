using Xunit;
using SearchLibrary;
using System.Linq;

namespace SearchLibrary.Tests
{
    public class OrderSearchTests
    {
        [Fact]
        public void BinarySearch_OrderIdFound()
        {
            var orders = new Order[]
            {
                new Order(101, "Alice", 200.5),
                new Order(102, "Bob", 150),
                new Order(103, "Charlie", 300)
            };

            var bs = new BinarySearch();
            int[] orderIds = orders.Select(o => o.OrderId).ToArray();

            Assert.Equal(1, bs.Search(102, orderIds)); // 102 at index 1
        }

        [Fact]
        public void LinearSearch_OrderIdNotFound()
        {
            var orders = new Order[]
            {
                new Order(101, "Alice", 200.5),
                new Order(102, "Bob", 150),
                new Order(103, "Charlie", 300)
            };

            var ls = new LinearSearch();
            int[] orderIds = orders.Select(o => o.OrderId).ToArray();

            Assert.Equal(-1, ls.Search(999, orderIds)); // 999 not in array
        }

        [Fact]
        public void JumpSearch_FirstOrder()
        {
            var orders = new Order[]
            {
                new Order(101, "Alice", 200.5),
                new Order(102, "Bob", 150),
                new Order(103, "Charlie", 300)
            };

            var js = new JumpSearch();
            int[] orderIds = orders.Select(o => o.OrderId).ToArray();

            Assert.Equal(0, js.Search(101, orderIds)); // First element
        }
    }
}