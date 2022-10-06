using CreatingAndUsingObject;
using System;

namespace CreatingAndUsingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i < 10; i++)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                Cat cat = new Cat(name);

            }
            
      
            
        }

            // 7. Define your own namespace CreatingAndUsingObjects and place in it 
            // two classes Cat and Sequence, which we used in the examples of the 
            // current chapter. Define one more namespace and make a class, which
            // calls the classes Cat and Sequence, in it.
            
    }
}