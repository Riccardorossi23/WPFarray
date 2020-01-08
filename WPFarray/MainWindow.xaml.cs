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
using System.IO;

namespace WPFarray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] frasi = new string[5]; int i;
        public MainWindow()
        {
            InitializeComponent();
        }
       

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            frasi[i] = txtInserisci.Text;
            i++;
           if(i==5)
           {
                btnInserisci.IsEnabled = false;
                btnPubblica.IsEnabled = true; 
                btnStampa.IsEnabled = true;
           }
            txtInserisci.Clear();
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (int i=0;i<frasi.Length;i++)
            {
                lblArray.Content += $"{frasi[i]}\n";
            }
        }

        private void btnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter w = new StreamWriter("pubblica.txt", false, Encoding.UTF8);
            for (int i = 0; i < frasi.Length; i++)
            {
                w.WriteLine($"-{i + 1}°  messaggio: {frasi[i]} \n");
            }
            w.Flush();
            w.Close();


        }
    }
}
