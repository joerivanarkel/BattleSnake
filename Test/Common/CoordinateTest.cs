using Common.Game;

namespace Test.Common;

public class CoordinateTest
{
    [Fact]
    public void TestDistance()
    {
        Coordinate coord1 = new(0, 0);
        Coordinate coord2 = new(0, 1);
        Coordinate coord3 = new(1, 0);
        Coordinate coord4 = new(1, 1);
        Coordinate coord5 = new(2, 2);

        Assert.Equal(1, coord1.Distance(coord2));
        Assert.Equal(1, coord1.Distance(coord3));
        Assert.Equal(2, coord1.Distance(coord4));
        Assert.Equal(4, coord1.Distance(coord5));
    }
}