// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 1 to run flip Coin");
Console.WriteLine("Enter 2 to run leap Year");
Console.WriteLine("Enter 3 to run power of two program");
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
}

