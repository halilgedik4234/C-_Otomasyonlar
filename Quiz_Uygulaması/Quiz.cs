using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_Uygulaması
{
    internal class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }

        private Question[] Questions { get; set; }

        private int QuestionIndex { get; set; }

        private int Score { get; set; }

        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];

        }

        public void DisplayQuestions()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"soru {this.QuestionIndex + 1}: {question.Text}");

            foreach (var a in question.Choices)
            {
                Console.WriteLine($" - {a}");
            }

            Console.Write("\nCevap: ");

            string cevap = Console.ReadLine();
            this.Guess(cevap);
        }

        private void Guess(string answer)
        {
            var question = this.GetQuestion();
            if (question.checkAnswer(answer))
                this.Score++;  //skor

            this.QuestionIndex++;

            if (this.Questions.Length == this.QuestionIndex)
            {
                //skor gösterme oyun bitince
                this.DisplayScore();
                PlayAgain();
                return;
            }
            else
            {
                this.DisplayQuestions();
            }
        }

        private void DisplayScore()
        {
            if (Score == Questions.Length)
                Console.WriteLine("Your Score 100");
            else
                Console.WriteLine($"Your Score: {(100 / Questions.Length) * this.Score} ");
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;
            if (totalQuestion >= questionNumber)
            {
                Console.WriteLine($"Question: {questionNumber}/{totalQuestion}");
            }
        }

        private void PlayAgain()
        {
            Console.WriteLine("Tekrar Oynamak İster misiniz ? (e/h)");
            string durum = Console.ReadLine();
            if (durum == "e" || durum == "evet")
            {
                this.QuestionIndex = 0;
                this.Score = 0;
                DisplayQuestions();
            }
            else
            {
                Console.WriteLine("Oyun kapanıyor");
            }
        }
    }
}
