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
using System.Windows.Navigation;
using System.Windows.Shapes;

using NeuroNet.Belinskiy;
using NeuroNet.Morozov;

namespace NeuroNet
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

        PerceptronBuilder perceptron = new PerceptronBuilder();
        BackPropagation points = new BackPropagation();
        List<double> clearSignal = new List<double>();
        List<double> noiseSignal = new List<double>();

        List<double> generateSignal(int count)
        {
            Random rand = new Random();

            List<double> signal = new List<double>(count);
            for (int i = 0; i < signal.Capacity; i++)
                signal.Add(rand.NextDouble());

            return signal;
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            Parser.Parser.Variable variableI;
            Parser.Parser parser = new Parser.Parser();

            parser = new Parser.Parser();
            parser.InputString = functionTextBox.Text;
            variableI = parser.GetVariable("x");

            PointCollection p = new PointCollection();

            Random r = new Random();
            

            for (float i = 0; i <= 10; i += 0.5f)
            {
                points.pointX.Add(i);
                variableI.value = i;
                clearSignal.Add(variableI.value);

                //variableI.value = (i % 3 == 0) ? i * (float)r.NextDouble() : i;
                //noiseSignal.Add(variableI.value);
                points.pointY.Add(parser.Calculate());
                p.Add(new Point(parser.Calculate(), i));
            }
                  

            chart.DataContext = p;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void networkParametersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            NetworkParametersWindow networkParameters = new NetworkParametersWindow();
            NeuronNetworkArchitecture archtecture = new NeuronNetworkArchitecture();

            if(networkParameters.ShowDialog() == true)
            {
                archtecture.CountInputNeurons = Convert.ToInt32(networkParameters.countInputNeurons.Text);
                archtecture.CountOutputNeurons = Convert.ToInt32(networkParameters.countOutputNeurons.Text);
                archtecture.CountHiddenLayers = Convert.ToInt32(networkParameters.countHiddenLayer.Text);
                archtecture.CountNeuronsInLayer = Convert.ToInt32(networkParameters.countNeuronsInHiddenLayer.Text);

                perceptron.Create(clearSignal, archtecture);
                points.SetNetwork(perceptron.NeuronNetwork());
                points.InitializationWeights();

                List<double> output = perceptron.NeuronNetwork().GetSignal();

                int hh;
            }
        }

        private void TrainingParametersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TrainingParametersWindow trainingParameters = new TrainingParametersWindow();
            StudyAlgorithm options = new StudyAlgorithm();

            if (trainingParameters.ShowDialog() == true)
            {
                options.step = Convert.ToDouble(trainingParameters.LearningStep.Text);
                options.maximumEpochs = Convert.ToInt32(trainingParameters.NumberOfEpochs.Text);
            }

        }
    }
}
