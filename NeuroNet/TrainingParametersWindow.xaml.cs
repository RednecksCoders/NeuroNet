using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NeuroNet
{
    /// <summary>
    /// Логика взаимодействия для TrainingParametersWindow.xaml
    /// </summary>
    public partial class TrainingParametersWindow : Window
    {
        public TrainingParametersWindow()
        {
            InitializeComponent();
        }

        private void use_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
