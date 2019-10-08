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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();


            Person bestPerson = Person.GetBestPerson();
            ShowPerson(bestPerson);

            Person person = new Person("Maxima","van Oranje");
            person.FirstName = "Maxima";
            ShowPerson(person);
        }

        public void ShowPerson(Person person)
        {
            var label = new Label();
            label.Content = person.ToString();
            MainStackPanel.Children.Add(label);
        }


    }
}
