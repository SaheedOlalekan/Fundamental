using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(GreaterThanNeighbours(new int[]{1}, 0));
            Console.WriteLine(GreaterThanNeighbours(new int[]{1,2,3}, 1));
            
            Console.WriteLine(GreaterThanNeighbours(new int[]{1,3,2}, 0));
            Console.WriteLine(GreaterThanNeighbours(new int[]{1,3,2}, 1));
            Console.WriteLine(GreaterThanNeighbours(new int[]{1,3,2}, 2));
           
           
        }

                // 5. Write a method that checks whether an element, from a certain index 
                // in an array is greater than its two neighbors. Test whether the 
                // method works correctly.

        static bool GreaterThanNeighbours(int [] myArray, int index)
        {
            bool  check = true;
            int greater = 0;
           if(index > 0 && index < myArray.Length - 1 && myArray.Length > 1)
           {
                if(myArray[index] - myArray[index - 1]  > 0 && myArray[index] - myArray[index + 1] > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
           }
            else if(index == 0 && myArray.Length > 1)
            {
                greater = myArray[index] - myArray[index + 1];
                
                    if(greater > 0)
                    {
                        check = true;
                    }
                    else 
                    {
                        check = false;
                    }    
            }
            else if(index == myArray.Length - 1 && myArray.Length > 1)
            {
                greater = myArray[myArray.Length - 1] - myArray[myArray.Length - 2];
                
                    if(greater > 0)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false; 
                    }   
            }
            else if(index == 0 && myArray.Length == 1)
            {
                greater = myArray[index];
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
