using YamlDotNet.RepresentationModel;

namespace CFnParser.AWS.Lambda
{
	public partial class Function
	{
		public string? Type { get; set; }
		public Propertie? @Properties { get; set; }

		public class Propertie
		{
			public List<string>? Architectures { get; set; }
			public Code? Code { get; set; }
			public string? CodeSigningConfigArn { get; set; }
			public DeadLetterConfig? DeadLetterConfig { get; set; }
			public string? Description { get; set; }
			public Environment? Environment { get; set; }
			public EphemeralStorage? EphemeralStorage { get; set; }
			public List<FileSystemConfig>? FileSystemConfigs { get; set; }
			public string? FunctionName { get; set; }
			public string? Handler { get; set; }
			public ImageConfig? ImageConfig { get; set; }
			public string? KmsKeyArn { get; set; }
			public List<string>? Layers { get; set; }
			public LoggingConfig? LoggingConfig { get; set; }
			public int? MemorySize { get; set; }
			public string? PackageType { get; set; }
			public int? ReservedConcurrentExecutions { get; set; }
			public string? Role { get; set; }
			public string? Runtime { get; set; }
			public RuntimeManagementConfig? RuntimeManagementConfig { get; set; }
			public SnapStart? SnapStart { get; set; }
			public List<Tag>? Tags { get; set; }
			public int? Timeout { get; set; }
			public TracingConfig? TracingConfig { get; set; }
			public VpcConfig? VpcConfig { get; set; }
		}

		public class Code
		{
			public string? ImageUri { get; set; }
			public string? S3Bucket { get; set; }
			public string? S3Key { get; set; }
			public string? S3ObjectVersion { get; set; }
			public string? ZipFile { get; set; }
		}

		public class DeadLetterConfig
		{
			public string? TargetArn { get; set; }
		}

		public class Environment
		{
			public YamlMappingNode? Variables { get; set; }
		}

		public class EphemeralStorage
		{
			public int? Size { get; set; }
		}

		public class FileSystemConfig
		{
			public string? Arn { get; set; }
			public string? LocalMountPath { get; set; }
		}

		public class ImageConfig
		{
			public List<string>? Command { get; set; }
			public List<string>? EntryPoint { get; set; }
			public string? WorkingDirectory { get; set; }
		}

		public class LoggingConfig
		{
			public string? ApplicationLogLevel { get; set; }
			public string? LogFormat { get; set; }
			public string? LogGroup { get; set; }
			public string? SystemLogLevel { get; set; }
		}

		public class RuntimeManagementConfig
		{
			public string? RuntimeVersionArn { get; set; }
			public string? UpdateRuntimeOn { get; set; }
		}

		public class SnapStart
		{
			public string? ApplyOn { get; set; }
		}

		public class TracingConfig
		{
			public string? Mode { get; set; }
		}

		public class VpcConfig
		{
			public bool? Ipv6AllowedForDualStack { get; set; }
			public List<string>? SecurityGroupIds { get; set; }
			public List<string>? SubnetIds { get; set; }
		}
	}
}
