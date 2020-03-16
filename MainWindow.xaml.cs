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

namespace Xaml_WPF_ListBox
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AddPerson(Object sender, RoutedEventArgs e)
        {
            string personToAdd = WriteSomeonesName.Text.ToLower();

            if(personToAdd != string.Empty && !InfectedPeopleList.Items.Contains(personToAdd))
            {
                InfectedPeopleList.Items.Add(personToAdd);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }
    }
}
