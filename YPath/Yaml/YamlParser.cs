using System.Text.RegularExpressions;

namespace YPath.Yaml
{
	public static class YamlParser
	{
		public static TreeData Parse(TreeData parent, string str, int tabSize = 2)
		{
			string patternEmptyLine = @"^(?<empty>\s+)$";
			string patternComment = @"^\s+#(?<comment>.*?)$";
			string patternKey = @"^(?<key>(?<indentkey>\s+)(?<valuekey>.*?):\s+)$";
			string patternKeyAndItem = @"^(?<kitem>(?<indentkitem>\s+)(?<valuekitem>.*?):\s+)$";
			string patternArrayItem = @"^(?<aitem>(?<indentaitem>\s+)(?<valueaitem>-.*?):\s+)$";
			string patternItem = @"^(?<item>(?<indentitem>\s+)(?<valueitem>-.*?):\s+)$";
			string patternValue = @"^(?<value>(?<indentvalue>\s+)(?<valuevalue>.*?):\s+)$";

			string pattern = $"({string.Join("|",
				new[]
				{
					patternEmptyLine,
					patternComment,
					patternKey,
					patternKeyAndItem,
					patternArrayItem,
					patternItem,
					patternValue,
				})})";

			var current = parent;
			int line = 0;
			int indent = 0;

			Match match;
			string currentStr = str;

			while ((match = Regex.Match(currentStr, pattern)).Success)
			{
				if (match.Groups["empty"].Success)
				{
					continue;
				}
				else if (match.Groups["comment"].Success)
				{
					current.AddChild("comment", match.Groups["comment"].Value);
				}
				else if (match.Groups["key"].Success)
				{
					current.AddChild("key", match.Groups["key"].Value);
				}

				// next loop
				currentStr = currentStr.Substring(match.Value.Length);
			}

			return parent;
		}
	}
}
