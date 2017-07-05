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

namespace YandxTransl
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

        private void textBox_SelectionChanged(object sender, EventArgs e)
        {
            exampleTB.Text = textBox.getSelectedText();
        }

        private void translateBtn_Click(object sender, RoutedEventArgs e)
        {
            transaltionTB.Text = translate(exampleTB.Text);
        }

        private string translate(string line)
        {
            return line;
        }

        private void exampleTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(autoTranslationCB.IsChecked==true)
                transaltionTB.Text = translate(exampleTB.Text);
        }

        private void addExampleBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ignoreExampleBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
