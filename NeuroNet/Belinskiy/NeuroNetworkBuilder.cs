using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    // абстрактный класс предназначенный для построения нейронной сети
    public abstract class NeuroNetworkBuilder
    {
        public NeuroNetworkBuilder()
        {
        }

        protected NeuronNetwork network = new NeuronNetwork(); // нейронная сеть
        protected List<double> inputSignal = new List<double>(); // входной сигнал
        protected Function activationFunction;

        public abstract NeuronLayer CreateInputLayer(int countNeurons); // создать входной слой

        public abstract NeuronLayer CreateOutputLayer(int countNeurons); // создать выходной слой

        public abstract NeuronLayer AddHiddenLayer(int countNeurons); // добавить скрытый слой

        public abstract void Create(NeuronNetworkArchitecture architecture); // создать сеть

        public virtual NeuronNetwork NeuronNetwork()
        {
            return network;
        }
    }
}
