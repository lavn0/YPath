namespace CFnParser.AWS.ApiGateway
{
	public class Resource
	{
		public string? Type { get; set; }
		public Propertie? @Properties { get; set; }

		public class Propertie
		{
			public string? ParentId { get; set; }
			public string? PathPart { get; set; }
			public string? RestApiId { get; set; }
		}
	}
}
