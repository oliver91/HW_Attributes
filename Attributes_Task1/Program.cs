
namespace Attributes_Task1
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass("MyClass", "Good class", 234, true, 0.234);
            Printer.Print(myClass);
        }
    }
}
