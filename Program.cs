var html = Markdig.Markdown.ToHtml(File.ReadAllText("./content/index.md"));
if(!Directory.Exists("./output")) Directory.CreateDirectory("./output");
File.WriteAllText("./output/index.html", html);