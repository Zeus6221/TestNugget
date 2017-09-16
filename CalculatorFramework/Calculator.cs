using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFramework
{
    public class Calculator
    {
        public int ExposeAdd(int a, int b)
        {
            AddProject.AddClass addObject = new AddProject.AddClass();
            return addObject.AddMethod(a, b);
        }

        public int ExposeSubstract(int a, int b)
        {
            SubstractProject.SubstractClass substractObject = new SubstractProject.SubstractClass();
            return substractObject.SubstractMethod(a, b);
        }

        public int ExposeMultiply(int a, int b)
        {
            MultiplyProject.MultiplyClass multiply = new MultiplyProject.MultiplyClass();
            return multiply.MultiplyMethod(a, b);
        }

        public double ExposeDivide(double a, double b)
        {
            DivideProject.DivideClass divideObject = new DivideProject.DivideClass();
            return divideObject.DivideMethod(a, b);
        }
    }
}
