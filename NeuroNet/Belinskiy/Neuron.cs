using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    
    /// <summary>
    /// нейрон  
    /// </summary> 
    public class Neuron
    {
        public string name = "";
        public static int number = 0; // порядковый номер нейрона

        private List<Synapse> inputs = new List<Synapse>();  // входные синапсы 
        private List<Synapse> outputs = new List<Synapse>(); // выходные синапсы
        private double shift; // смещение нейрона
        private Function activationFunction; // активационная функция, применяемая к нейрону

       
        public Neuron(Function activationFunction)
        {
            setName();

            this.activationFunction = activationFunction;
        }

        private void setName()
        {
            number++;
            name = "n" + number.ToString();
        }

        // добавить список входных синапсов
        //public void AddInput(List<Synapse> inputs)
        //{
        //    this.inputs = inputs;
        //}

        // добавить входной синапс
        public void AddInput(Synapse inputSynapse)
        {
            inputs.Add(inputSynapse);
        }

        // добавить выходной синапс
        public void AddOutput(Synapse outputSynapse)
        {
            outputs.Add(outputSynapse);
        }

        public List<Synapse> Inputs()
        {
            return inputs;
        }

        public List<Synapse> Outputs()
        {
            return outputs;
        }

        // задать смещение
        public void SetShift(double shift)
        {
            this.shift = shift;
        }

        public double GetShift()
        {
            return shift;
        }

        // получить активационный потенциал
        public double GetActivationPotential()
        {
            double activationPotential = 0;

            foreach (Synapse input in inputs)
            {
                activationPotential += input.GetSignal();
            }

            activationPotential += shift;

            return activationPotential;
        }

        public double GetSignal()
        {
            return activationFunction.GetValue(GetActivationPotential());
        }

        /// <summary>
        /// задать активационную функцию нейрона
        /// </summary> 
        public void SetActivationFunction(Function activFunc)
        {
            activationFunction = activFunc;
        }

        /// <summary>
        ///  соединяет текущий нейрон с нейроном переданным в качестве параметра
        /// </summary>
        public void ConnectNeuron(Neuron neuron)
        {
            Synapse newSynapse = new Synapse();
            newSynapse.SetParentNeurons(this, neuron);

            outputs.Add(newSynapse);
            neuron.inputs.Add(newSynapse);
        }
    }
}
