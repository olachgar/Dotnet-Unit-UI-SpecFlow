using Xunit;

namespace Dotnet_Unit_UI_SpecFlow.UI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        public void MyFirstTheory_Tests(int value, int expected)
        {
            Assert.Equal(expected, value);
        }

    }
}
