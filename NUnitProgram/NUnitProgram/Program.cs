using System;

namespace NUnitProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the NUnit Program Press- 1-Vending Machine, 2-Temprature Conversion, 3-Day of Week, 4-Monthly Payment, 5-Square Root, 6-To Binery, 7-Swap Binery, 8-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Amount to Change");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        VendingMachine vm = new VendingMachine();
                        vm.Calculate(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Temp. to change");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        TempratureConversion tc = new TempratureConversion();
                        tc.Calculate(temp);
                        break;
                    case 3:
                        DayOfWeek dw = new DayOfWeek();
                        dw.Day();
                        break;
                    case 4:
                        MonthlyPayment mp = new MonthlyPayment();
                        mp.Payment();
                        break;
                    case 5:
                       flag = false;
                        break;
                }
            }
        }
    }
}
