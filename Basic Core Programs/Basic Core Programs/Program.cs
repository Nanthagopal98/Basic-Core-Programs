// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 1 to run flip Coin");
Console.WriteLine("Enter 2 to run leap Year");
Console.WriteLine("Enter 3 to run power of two program");
Console.WriteLine("Enter 4 to run harmonic Value");
Console.WriteLine("Enter 5 to run prime Factors");
int value = Convert.ToInt32(Console.ReadLine());


switch (value)
{
    case 1:
        Basic_Core_Programs.flipCoin run1 = new Basic_Core_Programs.flipCoin();
        run1.flip();
        break;
    case 2:
        Basic_Core_Programs.leapYear run2 = new Basic_Core_Programs.leapYear();
        run2.checkLeapYear();
        break;
    case 3:
        Basic_Core_Programs.powerOf2 run3 = new Basic_Core_Programs.powerOf2();
        run3.findPowerOf2();
        break;
    case 4:
        Basic_Core_Programs.harmonicValue run4 = new Basic_Core_Programs.harmonicValue();
        run4.checkHarmonicValue();
        break;
    case 5:
        Basic_Core_Programs.primeFactors run5 = new Basic_Core_Programs.primeFactors();
        run5.findPrimeFactors();
        break;
}

