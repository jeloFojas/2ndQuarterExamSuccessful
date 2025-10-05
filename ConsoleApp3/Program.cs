using System;	
using System.ComponentModel;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Random random = new Random();
			string examSecondQuarter = "2nd Periodic Exam";
			int totalQuestions = 50;


			for (int answeredQuestions = 1; answeredQuestions <= totalQuestions; answeredQuestions++)
			{
				if (answeredQuestions == totalQuestions)
				{
					Console.WriteLine($"// {examSecondQuarter} - Question {answeredQuestions} of {totalQuestions} **ANSWERED**.");
					Console.WriteLine("Git.Commit(\"Final Answer\");");
					Console.WriteLine("Git.Push(\"To Grader\");");
					Console.WriteLine("Congratulations!");
					Console.WriteLine("See you maybe on next sem!");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine($"Answering Question {answeredQuestions}...");
					Thread.Sleep(1000);
				}

			}
			// System.Exit(0) - Process terminated successfully. **REST MODE ACTIVATED.**

		}
	}
}
