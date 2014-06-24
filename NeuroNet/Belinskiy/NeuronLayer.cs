using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    /// <summary>
    /// представляет слой неройнонной сети
    /// </summary>
    public class NeuronLayer
    {
        private List<Neuron> neurons = new List<Neuron>(); // список нейронов в слое

        public NeuronLayer()
        {
        }

        // добавляет в слой список нейронов
        //public void AddNeurons(List<Neuron> neurons)
        //{
        //    this.neurons = neurons;
        //}

        // добавляет в слой один нейрон
        public void AddNeuron(Neuron neuron)
        {
            neurons.Add(neuron);
        }

        // соединяет текущий слой со слоем layer
        public void ConnectLayer(NeuronLayer layer)
        {
            for (int i = 0; i < neurons.Count; i++)
            {
                for (int j = 0; j < layer.neurons.Count; j++)
                {
                    neurons[i].ConnectNeuron(layer.neurons[j]);
                }
            }
        }

        // возвращает список нейронов в слое
        public List<Neuron> Neurons()
        {
            return neurons;
        }

        // передает сигнал со входа на выход всех нейронов в слое
        public void Transfer()
        {
            foreach(Neuron neuron in neurons)
            {
                //double activationPotential = neuron.GetActivationPotential();
                //neuron.Outputs()[0].SetSignal(neuron.GetSignal());
                neuron.SetActivationFunction(new LinearFunction());

                foreach(Synapse output in neuron.Outputs())
                {
                    output.SetWeight(1);
                    output.SetSignal(neuron.GetSignal());
                }
            }
        }
    }
}
