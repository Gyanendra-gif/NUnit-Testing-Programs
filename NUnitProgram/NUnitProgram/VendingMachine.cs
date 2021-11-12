using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitProgram
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        int[] arr = new int [9];
        public void Calculate(int amount) 
        {
            // Count Notes
            for (int i = 0; i < arr.Length; i++)
            {
                if (amount >= notes[i])
                {
                    arr[i] = amount / notes[i];
                    amount = amount - arr[i] * notes[i];
                }
            }
            // Print notes
            for (int i = 0; i < 9; i++)
            {
                if (arr [i] != 0)
                {
                    Console.WriteLine(notes[i] +":"+ arr[i]); 
                }
            }

        }
    }
}
