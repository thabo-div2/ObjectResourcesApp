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

namespace ObjectResourcesApp
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

        private void Ok_OnClick(object sender, RoutedEventArgs e)
        {
            var brush = this.FindResource("myBrush") as RadialGradientBrush;
            if (brush != null)
            {
                var newB = brush.Clone();
                newB.GradientStops[1] = new GradientStop(Colors.Black, 1);
                Ok.Background = newB;
            }
            else 
            {
                MessageBox.Show("Current myBrush is not a RadialGradientBrush");
            }
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            Resources["myBrush"] = new SolidColorBrush(Colors.Red);
        }
    }
}
