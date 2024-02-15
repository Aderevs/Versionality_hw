using System.Security.Cryptography;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemplateMethodExample algorithm = new DerivedClass();
            algorithm.Run();
        }
    }
}
