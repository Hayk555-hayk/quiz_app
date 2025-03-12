namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    1
                ),
                new Question(
                    "What is the capital of England",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    2
                ),
                new Question(
                    "What is the capital of France",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    0
                ),
                new Question(
                    "What is the capital of Spain",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    3
                ),
            };

            Quiz myQuiz = new Quiz(questions);

            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
