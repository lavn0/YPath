using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.Utilities;

namespace CFnParser.Deserialize
{
	public class CustomDeserializer : IDeserializer
	{
		private readonly IValueDeserializer valueDeserializer;

		// 概要:
		//     Initializes a new instance of YamlDotNet.Serialization.Deserializer using the
		//     default configuration.
		//
		// 注釈:
		//     To customize the behavior of the deserializer, use YamlDotNet.Serialization.DeserializerBuilder.
		public CustomDeserializer()
			: this(new DeserializerBuilder().BuildValueDeserializer())
		{
		}

		//
		// 注釈:
		//     This constructor is private to discourage its use. To invoke it, call the YamlDotNet.Serialization.Deserializer.FromValueDeserializer(YamlDotNet.Serialization.IValueDeserializer)
		//     method.
		private CustomDeserializer(IValueDeserializer valueDeserializer)
		{
			this.valueDeserializer = valueDeserializer ?? throw new ArgumentNullException("valueDeserializer");
		}

		//
		// 概要:
		//     Creates a new YamlDotNet.Serialization.Deserializer that uses the specified YamlDotNet.Serialization.IValueDeserializer.
		//     This method is available for advanced scenarios. The preferred way to customize
		//     the behavior of the deserializer is to use YamlDotNet.Serialization.DeserializerBuilder.
		public static CustomDeserializer FromValueDeserializer(IValueDeserializer valueDeserializer)
		{
			return new CustomDeserializer(valueDeserializer);
		}

		public T Deserialize<T>(string input)
		{
			using StringReader input2 = new StringReader(input);
			return Deserialize<T>(input2);
		}

		public T Deserialize<T>(TextReader input)
		{
			return Deserialize<T>(new Parser(input));
		}

		public T Deserialize<T>(IParser parser)
		{
			return (T)Deserialize(parser, typeof(T));
		}

		public object? Deserialize(string input)
		{
			return Deserialize(input, typeof(object));
		}

		public object? Deserialize(TextReader input)
		{
			return Deserialize(input, typeof(object));
		}

		public object? Deserialize(IParser parser)
		{
			return Deserialize(parser, typeof(object));
		}

		public object? Deserialize(string input, Type type)
		{
			using StringReader input2 = new StringReader(input);
			return Deserialize(input2, type);
		}

		public object? Deserialize(TextReader input, Type type)
		{
			return Deserialize(new Parser(input), type);
		}

		//
		// 概要:
		//     Deserializes an object of the specified type.
		//
		// パラメーター:
		//   parser:
		//     The YamlDotNet.Core.IParser from where to deserialize the object.
		//
		//   type:
		//     The static type of the object to deserialize.
		//
		// 戻り値:
		//     Returns the deserialized object.
		public object? Deserialize(IParser parser, Type type)
		{
			if (parser == null)
			{
				throw new ArgumentNullException("parser");
			}

			if (type == null)
			{
				throw new ArgumentNullException("type");
			}

			bool flag = parser.TryConsume<StreamStart>(out _);
			bool flag2 = parser.TryConsume<DocumentStart>(out _);
			object result = null;
			if (!parser.Accept<DocumentEnd>(out _) && !parser.Accept<StreamEnd>(out _))
			{
				using SerializerState serializerState = new SerializerState();
				result = valueDeserializer.DeserializeValue(parser, type, serializerState, valueDeserializer);
				serializerState.OnDeserialization();
			}

			if (flag2)
			{
				parser.Consume<DocumentEnd>();
			}

			if (flag)
			{
				parser.Consume<StreamEnd>();
			}

			return result;
		}
	}
}
