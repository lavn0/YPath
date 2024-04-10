using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YPath.Yaml;

namespace YPathTest.Yaml
{
	[TestClass]
	public class YamlParserTest
	{
		[DataTestMethod]
		[DynamicData(nameof(GetSpritData))]
		public void ParseTest()
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
