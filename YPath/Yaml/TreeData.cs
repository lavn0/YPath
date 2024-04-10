namespace YPath.Yaml
{
	public class TreeData
	{
		public TreeData(
			string source,
			TreeData? parent = null,
			object? anchor = null,
			string? tag = null,
			bool plain = false,
			bool quoted = false,
			int style = 0,
			int startLine = 0,
			int startColumn = 0,
			int endLine = 0,
			int endColumn = 0,
			int line = 0,
			int column = 0)
		{
			Source = source;
			Parent = parent;
			Anchor = anchor;
			Tag = tag;
			Plain = plain;
			Quoted = quoted;
			Style = style;
			StartLine = startLine;
			StartColumn = startColumn;
			EndLine = endLine;
			EndColumn = endColumn;
			Line = line;
			Column = column;
		}

		public List<KeyValuePair<string, TreeData>> Children { get; } = new List<KeyValuePair<string, TreeData>>();

		public string Source { get; }
		public TreeData? Parent { get; set; }
		public object? Anchor { get; set; }
		public string? Tag { get; set; }
		public bool Plain { get; set; }
		public bool Quoted { get; set; }
		public int Style { get; set; }
		public int StartLine { get; set; }
		public int StartColumn { get; set; }
		public int EndLine { get; set; }
		public int EndColumn { get; set; }
		public int Line { get; }
		public int Column { get; }

		public void AddChild(string key, string value)
		{
			var treeData = new TreeData(value, parent: this);
			Children.Add(new KeyValuePair<string, TreeData>(key, treeData));
		}
	}
}
