using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string projectStatus = "Project: Exam v1.0";
			int totalQuestions = 50;

			for (int answeredQuestions = 0; answeredQuestions <= totalQuestions; answeredQuestions++)
			{
				if (answeredQuestions == totalQuestions)
				{
					Console.WriteLine($"// {projectStatus} - Question {answeredQuestions} of {totalQuestions} **ANSWERED**.");
					Console.WriteLine("Git.Commit(\"Final Answer\");");
					Console.WriteLine("Git.Push(\"To Grader\");");
				}
				else answeredQuestions++;
			}
			// System.Exit(0) - Process terminated successfully. **REST MODE ACTIVATED.**

		}
	}
}
