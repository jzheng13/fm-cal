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

namespace FMCal
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
            Dictionary<String, int> stats = new Dictionary<string, int>();
            foreach (TextBox tb in form.Children.OfType<TextBox>())
            {
                stats.Add(tb.Name, sanitize(tb.Text));
            }

            // Debug
            foreach(String k in stats.Keys)
            {
                System.Diagnostics.Debug.WriteLine(k);
            }
            
        }

        // Sanitize string input
        private int sanitize(String str)
        {
            int x;
            if (Int32.TryParse(str, out x))
            {
                return x;
            }
            // Debug
            System.Diagnostics.Debug.WriteLine(str);
            return 0;
        }

    }
}
