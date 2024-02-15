namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedDerivedClass();
            instance.TemplateMethod();
        }
    }
}
