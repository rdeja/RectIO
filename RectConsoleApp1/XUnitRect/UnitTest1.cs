using System;
using Xunit;
using RectConsoleApp1;

namespace XUnitRect
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rect rect = new Rect(2, 3);
            var ret = rect.Area();
            Assert.Equal(5, ret);
        }
    }
}
