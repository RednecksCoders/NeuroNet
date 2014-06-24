using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Belinskiy
{
    public struct NeuronNetworkArchitecture
    {
        private int countInputNeurons;
        private int countOutputNeurons;
        private int countHiddenLayers;
        private int countNeuronsInHiddenLayer;

        public int CountInputNeurons
        {
            set
            {
                countInputNeurons = value;
            }
            get
            {
                return countInputNeurons;
            }
        }

        public int CountOutputNeurons
        {
            set
            {
                countOutputNeurons = value;
            }
            get
            {
                return countOutputNeurons;
            }
        }

        public int CountHiddenLayers
        {
            set
            {
                countHiddenLayers = value;
            }
            get
            {
                return countHiddenLayers;
            }
        }

        public int CountNeuronsInLayer
        {
            set
            {
                countNeuronsInHiddenLayer = value;
            }
            get
            {
                return countNeuronsInHiddenLayer;
            }
        }
    }
}
