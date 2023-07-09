namespace Test;

using Business;
using Test.DummyData;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var request = RequestModelDummyData.CreateRequestModel();

        var moveService = new MoveService(request);
        var result = moveService.CalculateMove();
    }
}