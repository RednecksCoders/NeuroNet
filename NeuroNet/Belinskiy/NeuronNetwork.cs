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
        private NeuronLayer InputLayer = new NeuronLayer();// входной слой сети
        private NeuronLayer outputLayer = new NeuronLayer(); // выходной слой сети
        private List<NeuronLayer> hiddenLayers = new List<NeuronLayer>(); // список скрытых слоев сети
        
        public NeuronLayer inputLayer
        {
            set
            {
                InputLayer = value;
            }
            get
            {
                return InputLayer;
            }
        }

        public NeuronNetwork()
        {

        }

        // задать входной сигнал сети
        //public  void SetSignal(List<double> inputSignal)
        //{
        //    foreach(Neuron neuron in inputLayer.Neurons())
        //    {
        //        for (int i = 0; i < inputSignal.Count; i++ )
        //        {
        //            neuron.Inputs()[0].SetSignal(inputSignal[i]);
        //        }
        //    }
        //}

        // получить выходной сигнал сети
        public  List<double> GetSignal()
        {
                    

            return new List<double>(); // возвратить ВЫХОД СЕТИ  А НЕ ВХОДНОЙ СИГНАЛ  !!!!!!!  НЕЗАБУДЬ КОДЕР!!!!!!!!!!!!
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
    }       
        
}
