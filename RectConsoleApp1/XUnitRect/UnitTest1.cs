using System;
using Xunit;
using RectConsoleApp1;

namespace XUnitRect
{
    // my first unit test
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, -3, 6)]
        public void Test1(int w, int h, int result)
        {
            Rect rect = new Rect(w, h);
            var ret = rect.Area();
            Assert.Equal(result, ret);
        }
    }
}
