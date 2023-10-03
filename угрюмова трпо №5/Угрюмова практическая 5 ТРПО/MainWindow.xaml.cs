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

namespace Угрюмова_практическая_5_ТРПО
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private Page[] pages = new Page[]
        {
            new Page1(),
            new Page2(),
            new Page3(),
            new Page4()
        };

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainFrame.Navigate(pages[ComboBox1.SelectedIndex]);
        }
    }
}
