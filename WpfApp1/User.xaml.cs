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
    /// Users can log into the program to contribute to existing quiz log history
    /// </summary>
    public partial class User : Page
    {
        Quiz MyQuiz = new Quiz();

        public User()
        {
            InitializeComponent();
        }

        private void LogInExistingUser(object sender, RoutedEventArgs e)
        {

            /* SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\oscar\OneDrive\Documents\UserData.mdf; Integrated Security = True; Connect Timeout = 30");
             SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             if (dt.Rows[0][0].ToString() == "1")*/
            if (textBoxUsername.Text == "USER" && textBoxPassword.Password == "1234")
            {
                //Loads successful login page.
                //this.Hide();

                //TopicSelect ss = new TopicSelect();
                //ss.Show();

                NavigationService.Navigate(new Topics(MyQuiz));
            }
            else
            {
                MessageBox.Show("The Username or Password do match an existing users.");
                textBoxPassword.Clear();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //Loads New user page.

            //this.Hide();
            //NewLogin ss = new NewLogin();
            //ss.Show();
        }
    }
}

