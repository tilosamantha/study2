﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Quiz myQuiz = new Quiz();

        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("Hello There!");

            Main.Content = new QuestionSelection(myQuiz);
           
            //topicPage = new Topics(myQuiz);
           // Main.Content = topicPage;
        }
    }
}