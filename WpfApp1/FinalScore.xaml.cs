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

            // update score => calculateSCore
            //TODO
            Score.Content = Quiz.calculateScore(1, 1);
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Topics());
        }

        private void Retakebtn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new QuestionSelection());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.IO;

//namespace _2420StudyAid
//{
//    /// <summary>
//    /// Displays user's overall score on the quiz
//    /// </summary>
//    public partial class FinalScore : Page
//    {
//        public Quiz MyQuiz = new();


//        public FinalScore(Quiz myQuiz)
//        {
//            InitializeComponent();
//            MyQuiz = myQuiz;
//        }
//        string userData;


//        private void UserData(object sender, RoutedEventArgs e)
//        {
//            // ListBoxItem listBoxItem = (ListBoxItem)DelimiterDropDownList.SelectedItem;
//            // Console.WriteLine(listBoxItem);
//        }

//        private void HomeBtn_Click(object sender, RoutedEventArgs e)
//        {
//            NavigationService.Navigate(new Topics(MyQuiz));
//        }

//        private void Retakebtn_Click(object sender, RoutedEventArgs e)
//        {
//            NavigationService.Navigate(new QuestionSelection(MyQuiz));
//        }

//        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            Console.WriteLine(userData);

//        }
//    }
//}


