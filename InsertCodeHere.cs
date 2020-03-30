using System;

namespace WTF
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            MysticNumbers numbers1 = new MysticNumbers();
            int result1 = numbers1.ThreeNumbers(5, 10, 3);
            System.Console.WriteLine($"The highest number is {result1}");

            MysticNumbers numbers2 = new MysticNumbers();
            int result2 = numbers2.TwoNumbers(11, 10);
            System.Console.WriteLine($"The highest number is {result2}");

            MysticNumbers numbers3 = new MysticNumbers();
            int result = numbers3.FourNumbers(11, 12, 13, 14);
            System.Console.WriteLine($"The highest number is {result}");

            // The LAST line of code should be ABOVE this line
        }
    }
}