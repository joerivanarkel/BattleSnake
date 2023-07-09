using Business;
using Common.Requests;

namespace Test.StepDefinitions;

[Binding]
public class CheckCollisionSteps
{
    private ScenarioContext _scenarioContext;

    public CheckCollisionSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I check the collision of the RequestModel (.*)")]
    public void WhenICheckTheCollisionOfTheRequestModel(string name)
    {
        CollisionService collisionService = new();
        RequestModel requestModel = _scenarioContext.Get<RequestModel>(name);

        var result = collisionService.CheckCollision(requestModel);
        _scenarioContext.Add("result", result);
    }

    [Then(@"the collision should be (.*)")]
    public void ThenTheCollisionShouldBe(bool collision)
    {
        bool result = _scenarioContext.Get<bool>("result");
        result.Should().Be(collision);
    }




}
