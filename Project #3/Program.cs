using System;

class program {
    public static void Main(string[] args) {
        while (true)
        {   
            Console.Write("choose a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the nearest prime number is " + npn(n));
        }
    }

    public static int npn(int n) {

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) {n++; i = 2;}
        }
        return n;
    }
}