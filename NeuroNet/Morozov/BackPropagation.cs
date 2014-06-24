using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NeuroNet.Belinskiy;

namespace NeuroNet.Morozov
{
    public class BackPropagation : StudyWithTeacher
    {
        

        public void SetNetwork(NeuronNetwork network)
        {
            neuronNetwork = network;
        }

        public void BackpropagationError()
        {
            double currentError = Single.MaxValue; // текущая ошибка
            double lastError = 0; // последняя ошибка
            int epochNumber = 0; // номер эпохи
            StudyAlgorithm options = new StudyAlgorithm(); // ЗАЧЕМ ЭТО???  ты же наследуешь от этого класаа!!!!!!!!!
            

            do
            {
                lastError = currentError;

                int currentIndex = 0; // текущий индекс

                // эпоха
                do
                {
                    foreach(float point in pointX)
                    {

                    }
                    // Вычислить разность между выходом сети и требуемым выходом (целевым вектором обучающей пары).
                    // Подкорректировать веса сети для минимизации ошибки 

                } while (currentIndex < pointX.Count); //вместо 0 количество данных

                // пересчет ошибки currentError на всех данных 
                currentError = 0;
                for (int i = 0; i < 0; i++)
                {
                    // ....
                }
                currentError *= 1d / pointX.Count;

                epochNumber++;
            }
            while (epochNumber < options.maximumEpochs && currentError > options.MinError &&
                        Math.Abs(currentError - lastError) > options.MinErrorChange);
        }

        /// <summary>
        ///  инициализирует веса нейронов случайными числами в диапазоне [0, 1]
        /// </summary>
        public void InitializationWeights()
        {
            Random rand = new Random();

            NeuronLayer inputLayer = neuronNetwork.InputLayer();
            List<NeuronLayer> hiddenLayers;

            foreach (Neuron neuron in inputLayer.Neurons())
            {
                foreach (Synapse output in neuron.Outputs())
                {
                    output.SetWeight(rand.NextDouble());
                }
            }

            hiddenLayers = neuronNetwork.HiddenLayers();

            foreach(NeuronLayer layer in hiddenLayers)
            {
                foreach(Neuron neuron in layer.Neurons())
                {
                    foreach(Synapse output in neuron.Outputs())
                    {
                        output.SetWeight(rand.NextDouble());
                    }
                }
            }

        }

        
    }
}
