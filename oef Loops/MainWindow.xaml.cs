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

namespace oef_Loops
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

        private void MijnKnop_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                MijnTekstbox.AppendText(i + Environment.NewLine);
                MijnTekstbox.AppendText((i * i * i) + Environment.NewLine);
            }
        }
    }
}
