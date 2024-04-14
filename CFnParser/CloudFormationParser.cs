using System.Text;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace CFnParser.AWS
{
	public static class CloudFormationParser
	{
		public static TResult Parse<TResult>(string fileName)
		{
			using (var input = new StreamReader(fileName, Encoding.UTF8))
			{
				//var deserializer = new Deserializer();
				var deserializerBuilder = new DeserializerBuilder();

				deserializerBuilder.WithNodeTypeResolver(
					(a)=> { return a; },
					(syntax) => { });
				//deserializerBuilder.WithNodeTypeResolver(new CustomNodeTypeResolver());

				var deserializer = deserializerBuilder.Build();
				var deserializeObject = deserializer.Deserialize<TResult>(input);
				return deserializeObject;
			}
		}
	}

	internal class Factory : INodeTypeResolver
	{
		public bool Resolve(NodeEvent? nodeEvent, ref Type currentType)
		{
			throw new NotImplementedException();
		}
	}

	public class CustomNodeTypeResolver : INodeTypeResolver
	{
		public bool Resolve(NodeEvent? nodeEvent, ref Type currentType)
		{
			return true;
		}
	}
}
