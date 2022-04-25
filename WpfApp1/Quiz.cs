using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// Tracks the user's answers for each quiz taken.
    /// </summary>
    /// <author>
    /// Samantha Tilo
    /// </author>
    public class Quiz
    {
        public static int TotalQuestions { get; set; }
        private static int CorrectAnswers { get; set; }
        private static int IncorrectAnswers { get; set; }
        public static String? Topic { get; set;  }
        public static int CurrentQuestion { get; set; }
        public static IDictionary<string, string> QuizQuestions { get; set; }

        //private static Queue<int> Randomize;

        public Quiz()
        {
            TotalQuestions = 0;
            CurrentQuestion = 0;
            //topic = quizTopic;
            Topic = "";
        }

        public Quiz(int totalQuestions, int currentQuestion, String topic)
        {
            TotalQuestions = totalQuestions;
            CurrentQuestion = currentQuestion;
            Topic = topic;
        }


        /// <summary>
        /// Randomly selects {totalQuestions} from QuestionBank to populate quiz
        /// </summary>
        //public static void getQuestions(int numberOfQuestions, Dictionary<int, String> questionBank, Dictionary<int, String> answerBank)
        public static void getQuestions(int numberOfQuestions)
        {
            Random random = new Random();
            //generate {totalQuestions} numbers < QuestionBank.length

            //create new Dictionary to hold questions & associated answers
            for (int i = 0; i < TotalQuestions; i++)
            {
                int newQuestion = random.Next(0, QuestionBank.questionBank.Count);

               // if (Randomize.Contains(newQuestion))
               // {
               //     newQuestion = random.Next(0, QuestionBank.questionBank.Count);
               // } else
               // {
               //     Randomize.Enqueue(newQuestion);
               // }
                //quizQuestions.Add(QuestionBank.questionBank[i], AnswerBank.answerBank[i]);
            }



            foreach(string q in QuizQuestions.Keys)
            {
                Console.WriteLine(q);
            }
            // (LINQ) foreach random number generated, find question/answer key that matches
            //              add to new Dictionary
        }

        public static void showIndexCard(Dictionary<String, String> newDictionary)
        {
            //activated on next button press

            //fill index card with single question at index i
                //QuestionText.Text = quizQuestions[0];
            //1 correct answer, 2 incorrect answers
                //correct answer at index i
                //2 incorrect answers at 2 indexes other than i
            //randomly fill each answer box
                //queue?

        }

        /// <summary>
        /// Calculates the percentage of questions correctly answered.
        /// </summary>
        /// <param name="correct"></param>
        /// <param name="totalQuestions"></param>
        /// <returns></returns>
        public static int calculateScore(int correct, int totalQuestions)
        {
            return 5;
            //return correct / totalQuestions;
        }
    }

}
