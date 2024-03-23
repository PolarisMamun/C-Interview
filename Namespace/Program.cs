using System;

namespace Namespace
{
    public class Program
    {
        /*
        In C#, a namespace is a way to organize and group related types and members. 
        It is a way to create a scope that can hold its own types, fields,methods, properties, and events.
        Namespaces are used to avoid naming conflicts in large code bases.
         */
        static void Main(string[] args)
        {
            MyNamespace.MyClass myClass = new MyNamespace.MyClass();
            myClass.MyProperty = 10;
            myClass.PrintMyProperty();

            AnotherNamespace.AnotherClass anotherClass = new AnotherNamespace.AnotherClass();
            anotherClass.AnotherProperty = 20;
            anotherClass.PrintAnotherProperty();
        }

        /*
        In the above example, MyNamespace and AnotherNamespace are two namespaces that contain a class each.
        The MyClass class has a property MyProperty and a method PrintMyProperty() that prints the value of MyProperty.
        The AnotherClass class has a property AnotherProperty and a method PrintAnotherProperty() that prints the value of AnotherProperty.
        In the Main() method, we have created instances of both classes and printed their properties using their respective methods.
         */
    }
}
