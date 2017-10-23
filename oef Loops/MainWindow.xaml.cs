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
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            VertSlider.Minimum = 0;
            VertSlider.Maximum = MijnCanvas.Height;

            HorSlider.Minimum = 0;
            HorSlider.Maximum = MijnCanvas.Width;

            VertLabel.Content = Convert.ToString(VertSlider.Value);
            HorLabel.Content = Convert.ToString(HorSlider.Value);

            DrawElîpse();
        }



        private void VertSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int vertical = Convert.ToInt32(VertSlider.Value);
            VertLabel.Content = Convert.ToString(vertical);
        }

        private void HorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int horizontal = Convert.ToInt32(HorSlider.Value);
            HorLabel.Content = Convert.ToString(horizontal);
        }

        private void DrawElîpse()
        {
            ellipse = new Ellipse();
            ellipse.Width = HorSlider.Value;
            ellipse.Height = VertSlider.Value;
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.Fill = new SolidColorBrush(Colors.Black);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            MijnCanvas.Children.Add(ellipse);
        }

        private void UpdateEllipse()
        {
            ellipse.Width = HorSlider.Value;
            ellipse.Height = VertSlider.Value;
        }

    }
}
