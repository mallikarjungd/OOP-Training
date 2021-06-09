using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;

namespace OOP2
{
    class OOP2_Program :MyClass
    {
        static void Main(string[] args)
        {
            OOP1.MyClass myClass = new MyClass();

            myClass.publicVariable = "jedasdf";

           
            
        }
        void test()
        {
            protectedInternalMethod();
            protectedVariable = "hhsfd";
        }
    }
}
