# AWS Step Functions in C# using Serverless
Uses serverless plugin for step functions.

Simple example showing how to process lambdas in parllel, combine their
output and process it. The plugin supports establishing an Api Gateway endpoint to initiate
the state machine.

## Notes
Execution rest endpoint is asynchronous and returns something like:
```
{"executionArn":"arn:aws:states:us-west-2:455313538421:execution:calculation:48d2ff6c-a471-47c8-b8a1-226bdf6f212b","startDate":1.609371271535E9}
```
which contains the executionArn for the step function execution from which data can be queried.

## Next
- Try setting up a websocket API (w/auth) that allows for executing step function.
  - pass userid and connectionId into step function input
- calculation step drops calculation request output onto S3 (with userid/connectionId)
- S3-triggered lambda does calculation and saves in DynamoDB - with calculation userid/connectionId
- Dynamo stream-triggered lambda sends results to websocket API connectionId on result rows.
- WebSocket endpoint added to query completed calculations w/ optional filtering by user
- SPA UI hosted via lambda with OKTA auth that allows submitting one or more requests and displays results in real-time.




