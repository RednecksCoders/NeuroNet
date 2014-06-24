using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroNet.Morozov
{
    public class StudyWithTeacher : StudyAlgorithm
    {
        public List<float> pointX = new List<float>(); // вектор обучающих пар x
        public List<float> pointY = new List<float>(); // вектор обучающих пар y  
    }
}
