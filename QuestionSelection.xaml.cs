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
    /// User is prompted to select a number of questions to be quizzed on
    /// </summary>
    public partial class QuestionSelection : Page
    {
        public static Quiz MyQuiz = new();
        public static QuestionSlide newSlide = new(MyQuiz);

        //IDictionary<int, string> questionBank = new Dictionary<int, string>()
        //{
        //    [0] = "A variable defined by a class", //field
        //    [1] = "Symbols which transform and combine expressions", //operator
        //    [2] = "Introduces a new class", //clss statement
        //    [3] = "Data type that returns either true or false" //boolean
        //};

        public QuestionSelection(Quiz myQuiz)
        {
            InitializeComponent();
            MyQuiz = myQuiz;
        }

        private void quiz1(object sender, RoutedEventArgs e)
        {
            //newSlide.testLabel.Content = questionBank[0];
            NavigationService.Navigate(newSlide);
        }

        private void quiz2(object sender, RoutedEventArgs e)
        {
            //Quiz.totalQuestions = (int)medQuiz.Content;
            //NavigationService.Navigate(new QuestionSlide(MyQuiz));
        }

        private void quiz3(object sender, RoutedEventArgs e)
        {
           // Quiz.totalQuestions = (int)largeQuiz.Content;
            //NavigationService.Navigate(new QuestionSlide(MyQuiz));
        }

    }
}
