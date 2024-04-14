namespace YPathTest.Yaml
{
	[TestClass]
	public class YamlParserTest
	{
		[DataTestMethod]
		[DynamicData(nameof(GetSpritData))]
		public void ParseTest(string ypath, string[] array)
		{
		}

		private static IEnumerable<object[]> GetSpritData =>
			new List<string[]>()
			{
				new string[] { "/", "root" },
				new string[] { "/", "root", "/", "child" },
				new string[] { "/", "root", "/", "child", "/", "grand" },
				new string[] { "/", "root", "[", "predicate", "]" },
			}.Select(array => new object[] { string.Join("", array), array });
	}
}
