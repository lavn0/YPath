namespace YPathTest
{
	[TestClass]
	public class YPathTest
	{
		[DataTestMethod]
		[DynamicData(nameof(GetSpritData))]
		public void TestMethod(string str, string[] expected)
		{
			string[] actual = YPath.YPath.Split(str);
			CollectionAssert.AreEqual(expected, actual);
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