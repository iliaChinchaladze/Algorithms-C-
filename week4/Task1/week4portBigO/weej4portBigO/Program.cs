using System;

namespace weej4portBigO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;  //1
            int r = 0;  //1
            int dummy = 0;  //1

            Console.WriteLine("Creating a nested loop"); //1

            for (int i = 0; i < n; i++)   //n+1
            {
                Console.WriteLine("Inside the first loop");  //n

                dummy++; //n

                for (int j = 0; j < n; j++)      //n* (n-1)
                {

                    r = r + dummy; //n*n
                    Console.WriteLine("Inside the second loop " + r); // n*n


                }

            }


        } // 1+1+1+1+n+1+n+n*(n-1)+n*n = 
        //5+n+2n*n
        // Big(O) = O(n*n)
    }
}
