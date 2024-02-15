using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class TemplateMethodExample
    {
        public void Run()
        {
            StepOne();
            StepTwo();
            StepThree();
        }

        protected abstract void StepOne();
        protected abstract void StepTwo();
        protected abstract void StepThree();
    }

    class DerivedClass : TemplateMethodExample
    {
        protected override void StepOne()
        {
            Console.WriteLine("Step One");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("Step Two");
        }

        protected override void StepThree()
        {
            Console.WriteLine("Step Three");
        }
    }
}
