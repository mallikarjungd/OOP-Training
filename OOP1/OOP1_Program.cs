using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class OOP1_Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            

        }
        public void test()
        {
            MyClass obj = new MyClass();
            
        }

    }

    public class MyClass
    {
        private string privateVariable;
        public string publicVariable;
        internal string internalVariable;
        protected string protectedVariable;
        protected internal string protectedInternalVariable;

        #region Methods
        public void publicMethod()
        {
            Console.WriteLine("publicMethod");
        }

        private void privateMethod()
        {
            Console.WriteLine("privateMethod");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protectedMethod");
        }

        internal void internalMethod()
        {
            Console.WriteLine("internalMethod");
        }

        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("protectedInternalMethod");
        }

        #endregion

    }

    public class DerivedClass : MyClass 
    {
        protected int a;
        internal int b;
         public void test1()
        {
            MyClass obj = new MyClass();
            protectedVariable = "test";

            
                         

        }
    }

    public class OneMoreClass   :IInterface1,IInterface2
    {
       public void test2()
        {
            DerivedClass obj = new DerivedClass();

            MyClass myClass = new MyClass();
           
            
        }
    }

     interface IInterface1
    {

    }

    interface IInterface2
    {

    }

}
