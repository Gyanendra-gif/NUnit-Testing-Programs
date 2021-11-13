using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitProgram
{
    class TempratureConversion
    { //This will Return Cel. to Fah.
        public void CeltoFeh(float temp)
        {
            float value = ((temp * 9.0f / 5.0f) + 32.0f);
            Console.WriteLine("The Changed Value is:" + value);
        }
        //This will Return Cel. to Fah.
        public void FehToCel(float temp)
        {
            float value = (temp - 32.0f) * 5.0f / 9.0f;
            Console.WriteLine("The Changed Value is:" + value);
        }
        public void Calculate(float temp) 
        {
            Console.WriteLine("Press 1 to convert Cel. to Feh. or Press 2 to convert Feh. to Cel.");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    TempratureConversion tc = new TempratureConversion();
                    tc.CeltoFeh(temp);
                    break;
                case 2:
                    TempratureConversion tc1 = new TempratureConversion();
                    tc1.FehToCel(temp);
                    break;
            }
      }
    }
}