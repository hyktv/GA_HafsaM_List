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

namespace GA_HafsaM_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> studentNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            studentNames.Add("Will");
            studentNames.Add("Dylan");
            studentNames.Add("Hannah");
            studentNames.Add("Kristyn");
            studentNames.Add("Samantha");

            DisplayStudents();

        } //mainwindow


        private void DisplayStudents()
        {
            //clears text
            //rtbDisplay.Text = "";

            //loop through list 
            for (int i = 0; i < studentNames.Count; i++)
            {
                //append Index, name, and new line to rtbDisplay
                rtbDisplay.Text += $"{i} - {studentNames[i]}\n";
            }

            //display current student count 
            lblCurrentCount.Content = $"Student Count: {studentNames.Count}";

        } //DisplayStudent()

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //redisplay names of students
            studentNames.Add(txtStudentName.Text);
            DisplayStudents();

        } //btnAddStudent_Click

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            //validate value
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            //check if the number is between 0 and the last index in the list
            if(isANumber && index >= 0 && index < studentNames.Count)
            {
                MessageBox.Show(studentNames[index]);
            }
            else
            {
                MessageBox.Show("Invalid index.");
            }

        } //btnDisplayStudent_Click

        private void btnRemoveByIndex_Click(object sender, RoutedEventArgs e)
        {
            //validate value 
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            //check if the number is between 0 and the last index in the list
            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                studentNames.RemoveAt(index);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid Index.");
            }

        } //btnRemoveByIndex_Click




    } //class


}//namespace
