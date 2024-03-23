
using C_Interview.inheritance;
using C_Interview.StructClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace C_Interview
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*            Program program = new Program();
                        program.DataType();
                        program.ReferenceType();

                        Animal animal = new Animal();
                        Cat cat = new Cat();
                        animal.MakeSound();
                        cat.MakeSound();*/
            /*
                        List<Animal> animals = new List<Animal>();
                        animals.Add(new Dog());
                        animals.Add(new Cat());

                        foreach (Animal animal2 in animals)
                        {
                            animal2.MakeSound();
                        }*/

            /*PersonClass personClass = new PersonClass();
            PersonStruct personStruct = new PersonStruct();

            personClass.Name = "John";
            personClass.Age = 30;

            personStruct.Name = "Jane";
            personStruct.Age = 25;

            Console.WriteLine("Class - Name: " + personClass.Name + ", Age: " + personClass.Age);
            Console.WriteLine("Struct - Name: " + personStruct.Name + ", Age: " + personStruct.Age);

            ModifyClass(personClass);
            ModifyStruct(personStruct);

            Console.WriteLine("After modification");

            Console.WriteLine("Class - Name: " + personClass.Name + ", Age: " + personClass.Age);
            Console.WriteLine("Struct - Name: " + personStruct.Name + ", Age: " + personStruct.Age);
            GC.Collect();*/


            //implicit casting
            int myInt = 10;
            double myDouble = myInt;

            Console.WriteLine("implicit casting");
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Explicit casting
            Console.WriteLine("Explicit casting");
            double d = 12.34;
            int i = (int)d;

            Console.WriteLine(d);
            Console.WriteLine(i);

            //Conversions 
            Console.WriteLine("Conversions");
            string s = "123";
            int ic = Convert.ToInt32(s);
            Console.WriteLine(s);
            Console.WriteLine(ic);


            Console.ReadLine();
        }

        public void DataType()
        {
            int num1 = 10;
            int num2 = num1;

            num1 = 20;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
           
        }

        public void ReferenceType()
        {
            //string name1 = "Mamun";
            //string name2 = name1;

            //name1 = "Zarin";

            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            Person person1 = new Person("Mamun", 30);
            Person person2 = person1;

            person1.Name = "Bob";
            person1.Age = 40;
            Console.WriteLine(person1.Name,person1.Age);
            Console.WriteLine(person2.Name,person2.Age);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person2.Age);
        }

        static void ModifyClass(PersonClass person)
        {
            person.Name = "Modified John";
            person.Age = 40;
        }

        static void ModifyStruct(PersonStruct person)
        {
            person.Name = "Modified Jane";
            person.Age = 35;
        }
    }
}
