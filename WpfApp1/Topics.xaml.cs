using System;
using System.Collections.Generic;
using System.IO;
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
using static WpfApp1.Quiz;

namespace WpfApp1
{
    /// <summary>
    /// Allows selection of a quiz topic
    /// </summary>
    public partial class Topics : Page
    {
        Quiz MyQuiz = new Quiz();

        public Topics(Quiz myQuiz)
        {
            InitializeComponent();
            MyQuiz = myQuiz;
        }

        private void pickQuestions1(object sender, RoutedEventArgs e)
        {
            Quiz.Topic = (string?)CSharp.Content;
            //testQuiz.topic = (string?)CSharp.Content;

           // NavigationService.Navigate(new QuestionSelection());
            Console.WriteLine(MyQuiz);    
            //QuestionSelection.testBox.Text = topic;
        }
        private void pickQuestions2(object sender, RoutedEventArgs e)
        {
            Quiz.Topic = (string?)J.Content;
            //NavigationService.Navigate(new QuestionSelection());
        }
        private void pickQuestions3(object sender, RoutedEventArgs e)
        {
            Quiz.Topic = (string?)S.Content;
            //NavigationService.Navigate(new QuestionSelection());
        }

        private void newTopic(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new addNewTopic());
        }
    }
}
