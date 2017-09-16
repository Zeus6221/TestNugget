using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyProject
{
    public class MultiplyClass
    {
        public int MultiplyMethod(int a, int b)
        {
            int result = 0;
            AddProject.AddClass addObject = new AddProject.AddClass();
            for(int times= 0;times<b;times++)
            {
                result += a;
            }
            return result;
        }
    }
}
