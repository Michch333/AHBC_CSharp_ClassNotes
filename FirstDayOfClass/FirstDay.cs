using System;
using System.Dynamic;

namespace FirstDayOfClass
{
    class FirstDay
    {
        static void Main(string[] args)
        {
            double doubleToInt = 22.9;
            int castedInt = (int)doubleToInt;

            Console.WriteLine(castedInt);

            bool canDrink = castedInt == 21;
            Console.WriteLine(canDrink);

            int mikeAge = 26;

            bool mikeCanDrink = mikeAge > 21;
            bool mikeIsUnderAge = !mikeCanDrink;

            Console.WriteLine($"Mike can drink is {mikeCanDrink}, which would make mike is underage to: {mikeIsUnderAge}");
            Console.ReadLine();

        }
    }
}
