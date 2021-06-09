using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DummyClass
    {
        public DummyClass()
        {
            int i=10;
        }


        int variable1 = 0;
        public int fun1()
        {
            int i = 10;
            int j = 20;
            variable1 = i * j;
            
            return variable1;
        }
    }
}
