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

namespace _184988stringConcat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, RoutedEventArgs e)
        {
            //local variables
            string fName, lName, fullName;
            int yearBorn;

            //concatination
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            fName = fName.Trim();
            lName = lName.Trim();
            fullName = fName + " " + lName;
            yearBorn = calBDay.SelectedDate.Value.Year;

            if (fullName == "Ian Mctavish")
            {
                if (yearBorn >= 2000)
                {
                    lblOutput.Content = "You must be the student.";
                }

                else
                {
                    lblOutput.Content = "Hey cool cat, your name must be" + fullName;
                }
            }
            else
            {
                lblOutput.Content = fullName;
            }
        }
    }
}
