using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedTestingChallenge.Logic
{
    public class CalcService
    {
        public int Add(int a, int b)
        {
            return a + a;
        }

        public int Subtract(int a, int b)
        {
            return b - a;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
