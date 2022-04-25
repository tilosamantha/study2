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
    /// Displays user's overall score on the quiz
    /// </summary>
    public partial class FinalScore : Page
    {
        Quiz MyQuiz = new();
        public FinalScore(Quiz myQuiz)
        {
            InitializeComponent();
            MyQuiz = myQuiz;
            //FinalScore.score.Content = Quiz.calculateScore(1, 1);
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Topics());
        }

        private void Retakebtn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new QuestionSelection());
        }
    }
}
