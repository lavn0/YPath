using YamlDotNet.RepresentationModel;

namespace CFnParser.AWS
{
	public class CloudFormation
	{
		public string? AWSTemplateFormatVersion { get; set; }
		public YamlMappingNode? Parameters { get; set; }
		public CFnResource? Resources { get; set; }

		public class CFnResource
		{

		}
	}
}
