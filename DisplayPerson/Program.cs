using BasicOop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayPerson
{
    internal class Program
    {
        //https://www.exercisescsharp.com/oop/first-class-method-tostring
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Person myPerson = new Person();
            var personName = myPerson.Name;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Person name: ");
                personName = Console.ReadLine();
                list.Add(personName);
            }
            Console.WriteLine("\n\n");
            foreach (var item in list)
            {
                Console.WriteLine($"Hello! My name is {item}");
            }
            
            Console.ReadLine();
        }
    }
}
