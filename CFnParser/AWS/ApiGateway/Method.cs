using YamlDotNet.RepresentationModel;

namespace CFnParser.AWS.ApiGateway
{
	public class Method
	{
		public string? Type { get; set; }
		public Propertie? @Properties { get; set; }

		public class Propertie
		{
			public bool? ApiKeyRequired { get; set; }
			public List<string>? AuthorizationScopes { get; set; }
			public string? AuthorizationType { get; set; }
			public string? AuthorizerId { get; set; }
			public string? HttpMethod { get; set; }
			public Integration? Integration { get; set; }
			public List<MethodResponse>? MethodResponses { get; set; }
			public string? OperationName { get; set; }
			public YamlMappingNode? RequestModels { get; set; }
			public YamlMappingNode? RequestParameters { get; set; }
			public string? RequestValidatorId { get; set; }
			public string? ResourceId { get; set; }
			public string? RestApiId { get; set; }
		}

		public class Integration
		{
			public YamlSequenceNode? CacheKeyParameters { get; set; }
			public string? CacheNamespace { get; set; }
			public string? ConnectionId { get; set; }
			public string? ConnectionType { get; set; }
			public string? ContentHandling { get; set; }
			public string? Credentials { get; set; }
			public string? IntegrationHttpMethod { get; set; }
			public List<IntegrationResponse>? IntegrationResponses { get; set; }
			public string? PassthroughBehavior { get; set; }
			public YamlMappingNode? RequestParameters { get; set; }
			public YamlMappingNode? RequestTemplates { get; set; }
			public int TimeoutInMillis { get; set; }
			public string? Type { get; set; }
			public string? Uri { get; set; }
		}

		public class IntegrationResponse
		{
			public string? ContentHandling { get; set; }
			public YamlMappingNode? ResponseParameters { get; set; }
			public YamlMappingNode? ResponseTemplates { get; set; }
			public string? SelectionPattern { get; set; }
			public string? StatusCode { get; set; }
		}

		public class MethodResponse
		{
			public YamlMappingNode? ResponseModels { get; set; }
			public YamlMappingNode? ResponseParameters { get; set; }
			public string? StatusCode { get; set; }
		}
	}
}
