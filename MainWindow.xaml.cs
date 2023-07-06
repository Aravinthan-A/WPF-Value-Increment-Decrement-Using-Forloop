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

namespace IncrementDecrement
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Start = Convert.ToInt32(txthigh.Text);
            int increment = Convert.ToInt32(txttotal.Text);
            int Length = Convert.ToInt32(txtend.Text);


            for (int i = Start; i <Length; i =i+ increment) 
            { 
               lblresult.Content = lblresult.Content + ","+ i.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int start = Convert.ToInt32(txtname.Text);
            int increment = Convert.ToInt32(txtfirst.Text);
            int Length = Convert.ToInt32(txtlast.Text);


            for (int i = start; i > Length; i =i- increment)
            {
                lblshow.Content = lblshow.Content + ","+ i.ToString();
            }
            
        }
    }
}
