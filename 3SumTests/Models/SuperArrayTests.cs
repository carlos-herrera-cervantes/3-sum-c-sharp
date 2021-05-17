using System.Collections.Generic;
using _3SumConsoleApp.Models;
using Xunit;

namespace _3SumTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void GetThreeSum_Should_Return_ListOfList()
        {
            var numbers = new[] { -1, 0, 1, 2, -1, -4 };
            var result = SuperArray.GetThreeSum(numbers);

            Assert.Equal(result, new List<List<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } });
        }
    }
}
