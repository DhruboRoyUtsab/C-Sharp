namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add Questions Here
            Question[] questions = new Question[]
            {
                new Question
                (
                    "What is the capital of Germany?",
                    new string[] { "Paris", "London", "Madrid","Berlin" },
                    3
                ),
                new Question
                (
                    "What is 3*8+5?",
                    new string[] {"29", "22", "39", "13" },
                    0
                ),
                new Question
                (
                    "What is 2*11+1 ?",
                    new string[] { "22", "24", "23", "12" },
                    2
                ),

            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }

}
