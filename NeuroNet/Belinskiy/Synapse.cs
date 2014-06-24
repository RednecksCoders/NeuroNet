using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    // связь между нейронами (синапс)
    public class Synapse
    {
        private double signal; // сигнал передаваемый синапсом
        private double weight; // весовой коэффициент синапса

        private Neuron leftNeuron; // левый нейрон которому принадлежит синапс
        private Neuron rightNeuron; // правый нейрон которому принадлежит синапс

        // задать вес синапса
        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        // получить вес синапса
        public double GetWeight()
        {
            return weight;
        }

        // задать сигнал синапса
        public void SetSignal(double inputSignal)
        {
            signal = inputSignal;
        }

        // получить сигнал синапса
        public double GetSignal()
        {
            return signal * weight;
        }

        // задать нейроны, к которым присоединяется синапс
        public void SetParentNeurons(Neuron left, Neuron right)
        {
            leftNeuron = left;
            rightNeuron = right;
        }

        public Neuron GetLeftNeuron()
        {
            return leftNeuron;
        }

        public Neuron GetRightNeuron()
        {
            return rightNeuron;
        }
    }
}
