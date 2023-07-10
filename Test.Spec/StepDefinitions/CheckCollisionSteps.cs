using Business;
using Common.Requests;

namespace Test.StepDefinitions;

[Binding]
public class CheckCollisionSteps
{
    private readonly ScenarioContext _scenarioContext;

    public CheckCollisionSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"I check the collision of the RequestModel (.*)")]
    public void WhenICheckTheCollisionOfTheRequestModel(string name)
    {
        CollisionService collisionService = new();
        RequestModel requestModel = _scenarioContext.Get<RequestModel>(name);
    }

    [Then(@"the collision should be (.*)")]
    public void ThenTheCollisionShouldBe(bool collision)
    {
        bool result = _scenarioContext.Get<bool>("result");
        result.Should().Be(collision);
    }




}
