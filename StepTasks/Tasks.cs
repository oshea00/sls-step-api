using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.SystemTextJson;
using System.Collections.Generic;

public class Tasks
{
  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public TaskData GetDataOne(APIGatewayProxyRequest request)
  {
    return new TaskData {
      Source = "One",
      Message = "Data From One"
    };
  }

  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public TaskData GetDataTwo(APIGatewayProxyRequest request)
  {
    return new TaskData {
      Source = "Two",
      Message = "Data From Two"
    };
  }

  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public APIGatewayProxyResponse StartCalculation(List<TaskData> request)
  {
    return new APIGatewayProxyResponse {
      StatusCode = 200,
      Body = "Start Calculation"
    };
  }
}
