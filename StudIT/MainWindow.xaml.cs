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

namespace StudIT
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
        
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            lab1.Opacity = 100;
            lab2.Opacity = 100;
            but1.Visibility = Visibility.Hidden;
            tbox1.Opacity = 100;
            tbox2.Opacity = 100;
            but2.Opacity = 100;
            butc.Opacity=100;
           
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Stud max = new Stud();
            string s = tbox1.Text;
            max.SetName(s);
            string k = max.GetName();
            lab1.Content = k;
            tbox1.Text = "";
            string a = tbox2.Text;
            int n=Convert.ToInt32(a);
            max.SetAge(n);
            int z=max.GetAge();
            string l = Convert.ToString(z);
            lab2.Content = l;
            tbox2.Text = "";
            labP.Opacity = 100;
            labP.Content = max.prev();
            but2.Visibility = Visibility.Hidden;
            but3.Opacity = 100;
            lab3.Opacity = 100;
            tbox3.Opacity = 100;

        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            Studit di = new Studit();
            string s = tbox1.Text;
            di.SetName(s);
            string k = di.GetName();
            lab1.Content = k;
            tbox1.Text = "";
            string a = tbox2.Text;
            int n = Convert.ToInt32(a);
            di.SetAge(n);
            int z = di.GetAge();
            string l = Convert.ToString(z);
            lab2.Content = l;
            tbox2.Text = "";
            string p = tbox3.Text;
            di.SetLang(p);
            string j = di.GetLang();
            lab3.Content = j;
            tbox3.Text = "";
            labP.Content = di.prev();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lab1.Content = "Name:";
            lab2.Content = "Age:";
            lab3.Content = "Language:";
            labP.Content = "";
        }
    }
    
}
