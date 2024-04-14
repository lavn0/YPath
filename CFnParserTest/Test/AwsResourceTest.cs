using CFnParser.AWS.ApiGateway;
using CFnParser.AWS.Lambda;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CFnParser.AWS.CloudFormationParser;

namespace CFnParserTest.Test
{
	[TestClass]
	public class AwsResourceTest
	{
		[TestMethod]
		[DeploymentItem(@"Resource\AwsResource\Aws.ApiGateway.Deployent.yaml")]
		public void ParseTest_ApiGateway_Deployment()
		{
			Parse<Deployment>(@"Aws.ApiGateway.Deployent.yaml");
		}

		[TestMethod]
		[DeploymentItem(@"Resource\AwsResource\Aws.ApiGateway.Method.yaml")]
		public void ParseTest_ApiGateway_Method()
		{
			Parse<Method>(@"Aws.ApiGateway.Method.yaml");
		}

		[TestMethod]
		[DeploymentItem(@"Resource\AwsResource\Aws.ApiGateway.Resource.yaml")]
		public void ParseTest_ApiGateway_Resource()
		{
			Parse<Resource>(@"Aws.ApiGateway.Resource.yaml");
		}

		[TestMethod]
		[DeploymentItem(@"Resource\AwsResource\Aws.ApiGateway.Stage.yaml")]
		public void ParseTest_ApiGateway_Stage()
		{
			Parse<Stage>(@"Aws.ApiGateway.Stage.yaml");
		}

		[TestMethod]
		[DeploymentItem(@"Resource\AwsResource\Aws.Lambda.Function.yaml")]
		public void ParseTest_Lambda_Function()
		{
			Parse<Function>(@"Aws.Lambda.Function.yaml");
		}
	}
}