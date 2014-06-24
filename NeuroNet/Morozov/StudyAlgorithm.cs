using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NeuroNet.Belinskiy;

namespace NeuroNet.Morozov
{
    public class StudyAlgorithm
    {
       // нейронная сеть
        public NeuronNetwork neuronNetwork = new NeuronNetwork();

        // максимальное колво эпох
        public int maximumEpochs { get; set; }

        // Если совокупная ошибка для всех обучающих примеров является менее MinError, то алгоритм останавливается 
        public double MinError { get; set; }

        // шаг обучения
        public double step { get; set; }

        //Если изменение ошибки для всех обучающих примеров является менее MinErrorChange, то алгоритм останавливается
        public double MinErrorChange { get; set; }
    }
}
