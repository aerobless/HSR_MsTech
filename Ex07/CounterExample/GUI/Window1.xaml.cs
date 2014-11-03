using System.Windows;
using Library;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private ICounter counter;

        public Window1()
        {
            InitializeComponent();
            counter = new CounterImpl();
        }

        private void button_decrement(object sender, RoutedEventArgs e)
        {
            counter.Decrement();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter.Increment();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            counter.Reset();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}