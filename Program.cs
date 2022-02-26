Console.WriteLine("Hello, World!");
Console.WriteLine("Enter questions in a local file named \"questions.dat\"");

string questionsPath = Directory.GetCurrentDirectory() + "/questions.dat";

string codePath = Directory.GetCurrentDirectory() + "/code.ts";

string[] questionLines = File.ReadAllLines(questionsPath);

bool IsQuestion(String line)
{
  if (line.Length < 2) return false;
  return line.Trim().Substring(0, 2) != "//";
}

List<string> questions = new(Array.FindAll(questionLines, IsQuestion));

QuestionGenerator generator = new();

Console.WriteLine("Loading questions...\n");
foreach (string question in questions)
{
  string[] split = question.Split(',', StringSplitOptions.TrimEntries);
  string category = split[0];
  string questionText = split[1];
  List<string> options = new();
  for (int i = 2; i < split.Length; i++)
    options.Add(split[i]);

  Console.WriteLine(question);
  generator.Load(category, new Question(questionText, options.ToArray()));
}

Console.WriteLine("\nCompiling questions...");
string compiled = generator.Compile();
Console.WriteLine("Writing out code to local file \"code.ts\"...");
File.WriteAllText(codePath, generator.Compile());
Console.WriteLine("Done!");