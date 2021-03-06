// C# program for Minimize the absolute
// difference of sum of two subsets
using System;
 
class GFG {
     
    // function to print difference
    static void subsetDifference(int n)
    {
         
        // summation of n elements
        int s = n * (n + 1) / 2;
     
        // if divisible by 4
        if (n % 4 == 0) {
 
            Console.WriteLine("First "
            + "subset sum = " + s / 2);
                 
            Console.WriteLine("Second "
            + "subset sum = " + s / 2);
                 
            Console.WriteLine("Difference"
                              + " = " + 0);
        }
        else {
     
            // if remainder 1 or 2. In case
            // of remainder 2, we divide
            // elements from 3 to n in groups
            // of size 4 and put 1 in one
            // group and 2 in group. This
            // also makes difference 1.
            if (n % 4 == 1 || n % 4 == 2) {
     
                Console.WriteLine("First "
                + "subset sum = " + s / 2);
                 
                Console.WriteLine("Second "
                + "subset sum = " + ((s / 2)
                                      + 1));
                                       
                Console.WriteLine("Difference"
                               + " = " + 1);
            }
     
            // We put elements from 4 to n
            // in groups of size 4. Remaining
            // elements 1, 2 and 3 can
            // be divided as (1, 2) and (3).
            else
            {
                Console.WriteLine("First "
                + "subset sum = " + s / 2);
                 
                Console.WriteLine("Second "
                 + "subset sum = " + s / 2);
                        
                Console.WriteLine("Difference"
                                + " = " + 0);
            }
        }
    }
     
    /* Driver program to test above
    function */
    public static void Main()
    {
        int n = 6;
         
        subsetDifference(n);
    }
}