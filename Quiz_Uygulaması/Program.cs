using System;

namespace Quiz_Uygulaması
{
    class Question
    {
        public Question(string text, string[] choices,string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }

        public string Text { get; set; }

        public string[] Choices { get; set; }

        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En iyi programlama dili nedir ?", new string[] { "C#", "Javascript", "java", "Python" }, "C#");

            var q2 = new Question("En popüler programlama dili nedir ?", new string[] { "Python", "Javascript", "C#", "Java" }, "C#");

            var q3 = new Question("En çok kazandıran programlama dili nedir ?", new string[] { "JavaScript", "C#", "java", "Python" }, "C#");

            
            Question[] questions = new Question[]{ q1, q2, q3 };

            var quiz=new Quiz(questions);

            quiz.DisplayQuestions();

        }
    }
}
