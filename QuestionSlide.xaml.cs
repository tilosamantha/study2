using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lists a question and three options to answer with
    /// </summary>
    public partial class QuestionSlide : Page
    {
        public Quiz MyQuiz = new();


        static int questionCounter = Quiz.CurrentQuestion;

        public static IDictionary<int, string> questionBank = new Dictionary<int, string>()
        {
            [0] = "A variable defined by a class", //field
            [1] = "Symbols which transform and combine expressions", //operator
            [2] = "Introduces a new class", //clss statement
            [3] = "Data type that returns either true or false" //boolean
        };

        Quiz newQuiz = new(Quiz.TotalQuestions, questionCounter++, "C#");

        public QuestionSlide(Quiz myQuiz)
        {
            //display the next question
            Console.WriteLine($"Constructor accessing QuestionBank[{Quiz.CurrentQuestion}]: " + LoadData.questionBank[Quiz.CurrentQuestion]);
            MyQuiz = myQuiz;
            //Option.Content = questionBank[0];
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
         //   {
         //       NavigationService.Navigate(new FinalScore());
          //  }

       // private void Button_Click_1(object sender, RoutedEventArgs e)
       //     {

       //     }

        private void Next(object sender, RoutedEventArgs e)
        {
           if (questionCounter < questionBank.Count)
            {
                //create new Quiz object with updated currentQuestion
                //create new QuestionSlide with next question
                QuestionSlide newSlide = new(newQuiz);
                newSlide.testLabel.Content = questionBank[Quiz.CurrentQuestion];
               
                NavigationService.Navigate(newSlide);

                //testing
                Console.WriteLine("Next button accessing: " + questionCounter);
            } else
            {
                NavigationService.Navigate(new FinalScore(MyQuiz));
            }

            //update question text box, answer radio button texts
            //calculate scores
            //update user information
            //populate high scores
            // }
        }

    };
}