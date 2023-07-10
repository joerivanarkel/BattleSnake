using System.Data;
using Common.Board;
using Common.Game;
using Common.Requests;
using Common.You;
using Test.DummyData;

namespace Test.StepDefinitions;

[Binding]
public class CommonSteps
{
    private readonly ScenarioContext _scenarioContext;

    public CommonSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    
    
    [Given(@"a dummy RequestModel exists")]
    public void GivenADummyRequestModelExists(Table table)
    {
        // Loop through each row in the Gherkin table
        foreach (var row in table.Rows)
        {
            // Get the values from the columns in the current row
            var name = row["name"];
            var wallCollision = bool.Parse(row["WallCollision"]);
            var selfCollision = bool.Parse(row["SelfCollision"]);
            var otherCollision = bool.Parse(row["OtherCollision"]);

            // Create a new RequestModel object with the input data
            

            // TODO: Use the requestModel object in the test
            RequestModel requestModel = default!;

            switch (true)
            {
                case bool b when wallCollision:
                    continue;
                case bool b when selfCollision:
                    continue;
                case bool b when otherCollision:
                    continue;
                default:
                    requestModel = RequestModelDummyData.CreateRequestModel();
                    break;
            }

            _scenarioContext.Add(name, requestModel);
        }
    }

    

}
