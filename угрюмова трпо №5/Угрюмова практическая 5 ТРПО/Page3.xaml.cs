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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void textBox1_TextInput(object sender, TextCompositionEventArgs e)
        {
            OutputTextBlock.Text += "PreviewTextInput\n"; 

            if(ShowPropertiesCheckBox.IsChecked == true)
            {
                OutputTextBlock.Text += "Text: " + e.Text + "\n";
                OutputTextBlock.Text += "Device: " + e.Device + "\n";
                OutputTextBlock.Text += "Handled: " + e.Handled + "\n";
            }
        }

        private void textBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyDown\n";
            if (ShowPropertiesCheckBox.IsChecked == true)
            {
                OutputTextBlock.Text += $"Key (ToString): {e.Key}\n";
                OutputTextBlock.Text += $"Key (Приведение к int): {(int)e.Key}\n";
            }
        }

        private void textBox1_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyUp\n";
            if (ShowPropertiesCheckBox.IsChecked == true)
            {
                OutputTextBlock.Text += $"Key (ToString): {e.Key}\n";
                OutputTextBlock.Text += $"Key (Приведение к int): {(int)e.Key}\n";
            }
        }
    }
}
