using System;

class program {
    public static void Main(string[] args) {

        Console.Title = "the max";

        double num1, num2,num3, num1old;

        Console.Write("( X + Y ) * Z \n Pick X: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        num1old = 0-num1;

        Console.Write($"( {num1} + Y ) * Z \n Pick Y: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        num3 = 10;
        while (num3 >= 1)
        {
            Console.Write($"( {num1} + {num2} ) * Z \n Pick Z (must be under 1): ");
             num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
        }
        

        while (num1 != num1old)
        {
            Console.WriteLine($"({num1}+{num2})*{num3} = {(num1 + num2) * num3}");
            num1old = num1;
            num1 = (num1 + num2) * num3;
        }

        Console.ReadKey();
    }
}