using System;

namespace Attributes_Task1
{
    [AttributeUsage(AttributeTargets.Property)]
    class ForPrintAttribute : Attribute
    {
        public ConsoleColor Color { get; set; }

        public ForPrintAttribute()
        {
        }

        public ForPrintAttribute(ConsoleColor c)
        {
            Color = c;
        }
    }
}
