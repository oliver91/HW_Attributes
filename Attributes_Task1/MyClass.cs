using System;

namespace Attributes_Task1
{
    class MyClass
    {
        [ForPrintAttribute(ConsoleColor.Magenta)]
        public string Name { get; private set; }
        [ForPrintAttribute(ConsoleColor.Cyan)]
        public string Desctiption { get; private set; }
        public int Val { get; private set; }
        [ForPrintAttribute(ConsoleColor.Green)]
        public bool Flag { get; private set; }
        public double Dval { get; private set; }

        public MyClass(string n, string d, int v, bool f, double dv)
        {
            Name = n;
            Desctiption = d;
            Val = v;
            Flag = f;
            Dval = dv;
        }
    }
}
