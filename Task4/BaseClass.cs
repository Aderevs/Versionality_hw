using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class BaseClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            Operation3();
        }

        protected virtual void Operation1()
        {
            Console.WriteLine("Base Operation 1");
        }

        protected virtual void Operation2()
        {
            Console.WriteLine("Base Operation 2");
        }

        protected abstract void Operation3();
    }

    class DerivedClass : BaseClass
    {
        protected override void Operation2()
        {
            Console.WriteLine("Derived Operation 2");
        }

        protected override void Operation3()
        {
            Console.WriteLine("Derived Operation 3");
        }
    }

    class DerivedDerivedClass: DerivedClass
    {
        protected override void Operation1()
        {
            Console.WriteLine("Derived derived Operation 1");
        }
    }

}
