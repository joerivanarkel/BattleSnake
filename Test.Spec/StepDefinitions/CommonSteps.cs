namespace Test.StepDefinitions;

[Binding]
public class CommonSteps
{
    private ScenarioContext _scenarioContext;

    public CommonSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    
    
    [Given(@"a dummy RequestModel exists")]
    public void GivenADummyRequestModelExists()
    {
        
    }

}
