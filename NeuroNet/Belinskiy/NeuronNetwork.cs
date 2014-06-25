using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    /// <summary>
    /// нейронная сеть
    /// </summary>
    public class NeuronNetwork
    {
        private NeuronLayer inputLayer = new NeuronLayer();// входной слой сети
        private NeuronLayer outputLayer = new NeuronLayer(); // выходной слой сети
        private List<NeuronLayer> hiddenLayers = new List<NeuronLayer>(); // список скрытых слоев сети

        List<double> signal = new List<double>();

        public NeuronNetwork()
        {

        }

        // задать входной сигнал сети
        public void SetSignal(List<double> inputSignal)
        {
            int numInput = 0;
            
            foreach (Neuron neuron in inputLayer.Neurons())
            {
                foreach (Synapse input in neuron.Inputs())
                {
                    input.SetSignal(inputSignal[numInput]);
                    numInput++;
                }
            }
                
        }

        // получить выходной сигнал сети
        public  List<double> GetSignal()
        {
            List<double> outputSignal;

            NeuronLayer layer = inputLayer;
            layer.Transfer();

            if (hiddenLayers.Count > 0)
            {
                foreach(NeuronLayer hiddenLayer in hiddenLayers)
                {
                    hiddenLayer.Transfer();
                    int hh;
                }
            }

            outputLayer.Transfer();

            outputSignal = new List<double>();

            foreach(Neuron outputNeuron in outputLayer.Neurons())
            {
                foreach(Synapse output in outputNeuron.Outputs())
                {
                    outputSignal.Add(output.GetSignal());  // ВЕС НА ВЫХОДНЫХ СИНАПСАХ НАДО УТОЧНИТЬ
                }
            }

            return outputSignal; 
        }

        
        
        // устанавливает входной слой 
        public void SetInputLayer(NeuronLayer layer)
        {
            inputLayer = layer;
        }

        // устанавливает выходной слой
        public void SetOutputLayer(NeuronLayer layer)
        {
            outputLayer = layer;
        }


        // добавляет скрытый слой
        public void AddHiddenLayer(NeuronLayer layer)
        {
            hiddenLayers.Add(layer);
        }

        public NeuronLayer InputLayer()
        {
            return inputLayer;
        }

        public NeuronLayer OutputLayer()
        {
            return outputLayer;
        }

        public List<NeuronLayer> HiddenLayers()
        {
            return hiddenLayers;
        }
    }       
        
}
