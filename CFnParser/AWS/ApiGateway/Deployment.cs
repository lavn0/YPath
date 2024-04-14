using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace CFnParser.AWS.ApiGateway
{
	public class Deployment
	{
		public string? Type { get; set; }
		public Propertie? @Properties { get; set; }

		public class Propertie
		{
			public List<DeploymentCanarySettings>? DeploymentCanarySettings { get; set; }
			public string? Description { get; set; }
			public string? RestApiId { get; set; }
			public StageDescription? StageDescription { get; set; }
			public string? StageName { get; set; }
		}

		public class DeploymentCanarySettings
		{
			public double? PercentTraffic { get; set; }
			public YamlMappingNode? StageVariableOverrides { get; set; }
			public bool UseStageCache { get; set; }
		}

		public class StageDescription
		{
			public AccessLogSetting? AccessLogSetting { get; set; }
			public bool? CacheClusterEnabled { get; set; }
			public string? CacheClusterSize { get; set; }
			public bool? CacheDataEncrypted { get; set; }
			public int? CacheTtlInSeconds { get; set; }
			public bool? CachingEnabled { get; set; }
			public CanarySetting? CanarySetting { get; set; }
			public string? ClientCertificateId { get; set; }
			public bool? DataTraceEnabled { get; set; }
			public string? Description { get; set; }
			public string? DocumentationVersion { get; set; }
			public string? LoggingLevel { get; set; }
			public List<MethodSetting>? MethodSettings { get; set; }
			public bool? MetricsEnabled { get; set; }
			public List<Tag>? Tags { get; set; }
			public int? ThrottlingBurstLimit { get; set; }
			public double? ThrottlingRateLimit { get; set; }
			public bool? TracingEnabled { get; set; }
			public YamlMappingNode? Variables { get; set; }
		}
		public class AccessLogSetting
		{
			public string? DestinationArn { get; set; }
			public string? Format { get; set; }
		}

		public class CanarySetting
		{
			public int? PercentTraffic { get; set; }
			public YamlMappingNode? StageVariableOverrides { get; set; }
			public bool? UseStageCache { get; set; }
		}

		public class MethodSetting
		{
			public bool? CacheDataEncrypted { get; set; }
			public int? CacheTtlInSeconds { get; set; }
			public bool? CachingEnabled { get; set; }
			public bool? DataTraceEnabled { get; set; }
			public string? HttpMethod { get; set; }
			public string? LoggingLevel { get; set; }
			public bool? MetricsEnabled { get; set; }
			public string? ResourcePath { get; set; }
			public int? ThrottlingBurstLimit { get; set; }
			public double? ThrottlingRateLimit { get; set; }
		}
	}
}
