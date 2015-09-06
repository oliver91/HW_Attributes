using System;
using System.Reflection;

namespace Attributes_Task1
{
    static class Printer
    {
        public static void Print<T>(T obj)
        {
            var type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for(int i = 0; i < properties.Length; i++)
            {
                var attributes = properties[i].GetCustomAttributes(false);
                foreach (var attribute in attributes)
                {
                    if (attribute.GetType() == typeof (ForPrintAttribute))
                    {
                        ForPrintAttribute att = attribute as ForPrintAttribute;
                        Console.ForegroundColor = att.Color;
                        Console.WriteLine(properties[i].GetValue(obj, null));
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
