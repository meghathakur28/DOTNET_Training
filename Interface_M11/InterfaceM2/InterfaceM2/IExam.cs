using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceM2
{
    public interface IExam
    {
        public double calculateScore();
        public string evaluateResult(double percentage);
    }
}
