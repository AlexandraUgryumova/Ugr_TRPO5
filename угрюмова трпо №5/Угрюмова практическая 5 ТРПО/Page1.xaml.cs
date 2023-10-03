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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            textBlock1.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }
        private void Control_MouseDownPreview(object sender, MouseButtonEventArgs e)
        {
            textBlock2.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            textBlock2.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }
    }
}
