using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.SystemTextJson;

public class WebSocketHandler
{
  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public APIGatewayProxyResponse OnConnect(APIGatewayProxyRequest request)
  {
    return new APIGatewayProxyResponse {
      StatusCode = 200,
      Body = $"OnConnect"
    };
  }

  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public APIGatewayProxyResponse OnDisconnect(APIGatewayProxyRequest request)
  {
    return new APIGatewayProxyResponse {
      StatusCode = 200,
      Body = "Connect"
    };
  }

  [LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]
  public APIGatewayProxyResponse SubmitCalculation(APIGatewayProxyRequest request)
  {
    return new APIGatewayProxyResponse {
      StatusCode = 200,
      Body = "Submit Calculation"
    };
  }
}
