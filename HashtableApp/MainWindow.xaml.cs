using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void bttnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((txtKey.Text == "") && (txtValue.Text == "")) 
            {
                MessageBox.Show("Please Input your key or value");
            }
            else
            {
                hashtable.Add((txtKey.Text), (txtValue.Text));

                MessageBox.Show(" Add Sucessfully");

                txtKey.Clear();
                txtValue.Clear();
            }
        }

        private void bttnRemove_Click(object sender, RoutedEventArgs e)
        {
           
                hashtable.Remove(txtKey.Text.ToString());
                MessageBox.Show(" Remove Sucessfully");
                txtKey.Clear();
                txtValue.Clear();
            
        }

        private void bttnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }

        }

        private void bttnClear_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Clear();
        }
    }

}

   