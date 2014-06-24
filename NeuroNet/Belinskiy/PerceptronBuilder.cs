using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace NeuroNet.Belinskiy
{
    public class PerceptronBuilder : NeuroNetworkBuilder
    {
        public PerceptronBuilder()
        {
        }

        public override NeuronLayer CreateInputLayer(int countNeurons, List<double> inputSignal)
        {
            //if (inputSignal.Count == countNeurons)
            //{
                NeuronLayer layer = new NeuronLayer();

                for (int i = 0; i < countNeurons; i++)
                {
                    Synapse synapse = new Synapse();
                    Neuron neuron = new Neuron(new LinearFunction());

                    //synapse.SetSignal(inputSignal[i]);
                    //synapse.SetWeight(1);
                    //neuron.SetShift(0);

                    synapse.SetParentNeurons(null, neuron);
                    
                    neuron.AddInput(synapse);

                    layer.AddNeuron(neuron);
                }

                network.SetInputLayer(layer);

                return layer;
            //}
            //else
            //{
            //    MessageBox.Show("lol ... countNeurons не равно signal.Count");
            //    return null;
            //}
        }

        public override NeuronLayer CreateOutputLayer(int countNeurons)
        {
            NeuronLayer layer = new NeuronLayer();

            for (int i = 0; i < countNeurons; i++)
            {
                Neuron neuron = new Neuron(new SigmoidFunction());
                Synapse synapse = new Synapse();

                synapse.SetParentNeurons(neuron, null);
                neuron.AddOutput(synapse);

                layer.AddNeuron(neuron);
            }

            network.SetOutputLayer(layer);

            return layer;
        }

        public override NeuronLayer AddHiddenLayer(int countNeurons)
        {
            NeuronLayer layer = new NeuronLayer();

            for (int i=0; i<countNeurons; i++)
            {
                Neuron newNeuron = new Neuron(new SigmoidFunction());
                
                layer.AddNeuron(newNeuron);
            }

            network.AddHiddenLayer(layer);

            return layer;
        }

        /// <summary>
        /// создает персептрон
        /// </summary>
        /// <param name="signal">входной сигнал перцептрона</param>
        /// <param name="architecture">информация об структуре сети</param>
        public override void Create(List<double> signal, NeuronNetworkArchitecture architecture)
        {
            

            NeuronLayer inputLayer = CreateInputLayer(architecture.CountInputNeurons, signal);
            NeuronLayer hiddenLayer1 = AddHiddenLayer(2);
            NeuronLayer hiddenLayer2 = AddHiddenLayer(2);
            NeuronLayer outputLayer = CreateOutputLayer(architecture.CountOutputNeurons);

          //  network.SetSignal(signal);

            inputLayer.ConnectLayer(hiddenLayer1);
            hiddenLayer1.ConnectLayer(hiddenLayer2);
            hiddenLayer2.ConnectLayer(outputLayer);



            activationFunction = new SigmoidFunction();

            inputLayer.Transfer();
            hiddenLayer1.Transfer();
            hiddenLayer2.Transfer();
            outputLayer.Transfer();

            int hh;
        }


    }
}
