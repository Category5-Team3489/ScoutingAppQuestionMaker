public class QuestionGenerator
{
  public readonly Dictionary<string, List<Question>> questions = new();

  public void Load(string category, Question question)
  {
    if (!questions.ContainsKey(category))
      questions.Add(category, new List<Question>());
    List<Question> section = questions[category];
    section.Add(question);
  }

  private string[] CompileQuestionItems(Question question)
  {
    List<string> l = new();
    int value = 0;
    l.Add("  questionItems: [");
    foreach (string option in question.Options)
    {
      l.Add("    {");
      l.Add($"      value: {value},");
      l.Add($"      itemText: {option}");
      l.Add("    },");
      value++;
    }
    if (question.Options.Length > 0)
      l[l.Count - 1] = "    }";
    l.Add("  ],");
    return l.ToArray();
  }

  private string[] CompileGeneral(string category, string idPrefix)
  {
    List<Question> categoryQuestions = questions[category];
    List<string> l = new();
    int id = 1;
    foreach (Question question in categoryQuestions)
    {
      l.Add("{");
      l.Add($"  id: \'{idPrefix}{id}\',");
      l.Add($"  questionText: {question.Text},");
      string questionType = question.Options.Length == 0 ? "1" : "2";
      l.Add($"  questionType: {questionType},");
      l.AddRange(CompileQuestionItems(question));
      l.Add("  answer: 0");
      l.Add("},");
      id++;
    }
    l[l.Count - 1] = "}";
    return l.ToArray();
  }

  private string Append(string[] lines)
  {
    string text = "";
    foreach (string line in lines)
      text += "        " + line + "\n";
    return text;
  }

  public string Compile()
  {
    string compiled = 
    "    this.questions = {\n" +
    "      Autonomous: [\n" +
    Append(CompileGeneral("auto", "AQ")) +
    "      ],\n\n" +
    "      Teleop: [\n" +
    Append(CompileGeneral("teleop", "TQ")) +
    "      ],\n\n" +
    "      EndGame: [\n" +
    Append(CompileGeneral("end", "EQ")) +
    "      ]\n" +
    "    };";
    return compiled;
  }
}