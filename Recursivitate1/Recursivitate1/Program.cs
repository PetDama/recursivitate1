using System;

namespace Recursivitate1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vector = new int[] { 5, 6, 7, 8, 9, 10 };
            Recursivitate.ParcurgereVector(vector, vector.Length);

        }
    }
}