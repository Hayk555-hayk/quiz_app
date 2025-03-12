using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1;

            foreach(Question question in _questions)
            {
                Console.WriteLine($"Question number - {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice(question.Answers.Length);


                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong ! The correct answer was {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResults();
        }

        private void DisplayResults()
        {
            double percentage = (double)_score / (double)_questions.Length;
            Console.WriteLine($"RESULT: {_score} out of {_questions.Length} - {percentage}%");
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("|             QUESTION           |");
            Console.WriteLine("|--------------------------------|");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);
            for(int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private int GetUserChoice(int answersCount)
        {
            Console.WriteLine("Your ansver (Number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while(!int.TryParse(input, out choice) || choice < 1 || choice > answersCount)
            {
                Console.WriteLine($"Invalid Choice, please enter a number between 1 - {answersCount}");
                input = Console.ReadLine();
            }

            return choice - 1;
        }
    }
}
