using System.Text.RegularExpressions;

namespace YPath
{
	public class YPath
	{
		public string FullPath { get; }
		public List<string> Segments { get; }
		public List<string> Predicates { get; }

		public YPath(string str)
		{
			FullPath = str;
			Segments = new List<string>();
			Predicates = new List<string>();
		}

		public static string[] Split(string str)
		{
			const string pattern = @"(?<!^)(?=(?<=(\\\\)*)[/\.\[\]='""])|(?<=(?<=(\\\\)*)[/\.\[\]='""])(?!$)";
			var result = Regex.Split(str, pattern);
			return result;
		}
	}
}