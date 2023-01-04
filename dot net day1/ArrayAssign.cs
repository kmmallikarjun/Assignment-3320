using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmments
{
    class ArrayAssign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the size of array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the cts equivalent name for the type of the array that u want to create ");
            string typeName = Console.ReadLine();
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value of type {type.Name}");
                string enteredValue = Console.ReadLine();
                object convertedValue = Convert.ChangeType(enteredValue, type);
                myArray.SetValue(convertedValue, i);

            }
            Console.WriteLine("all the values are set");
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}