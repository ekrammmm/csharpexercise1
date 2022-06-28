using System;

public class ReverseExample

{

    public static void Main(string[] args)
    {
        char ans = 'Y';

        while (ans == 'Y' || ans == 'y')
        {

            {
                int n, reverse = 0, rem;

                Console.WriteLine("Enter a number: ");


                n = int.Parse(Console.ReadLine());

                while (n != 0)

                {

                    rem = n % 10;

                    reverse = reverse * 10 + rem;

                    n /= 10;


                }

                Console.Write("Reversed Number: " + reverse);

            }
            Console.WriteLine("\npress y to continue or n to exit\n");
            ans = char.Parse(Console.ReadLine());

        }
       
    }
}