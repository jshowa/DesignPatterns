using System;

namespace DesignPatterns
{
    public class Program
    {
        public string MyProperty { get; set; }

        public Program(string x)
        {
            MyProperty = x;
        }

        public void PrintToConsole()
        {
            Console.WriteLine(MyProperty);
        }
    }
}
