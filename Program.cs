using System;

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number <=10){
            Console.Write("Your number is ");
            switch (number){
                case 1:
                    Console.WriteLine("One.");
                    break;
                case 2:
                    Console.WriteLine("Two.");
                    break;
                case 3:
                    Console.WriteLine("Three.");
                    break;
                case 4:
                    Console.WriteLine("Four.");
                    break;
                case 5:
                    Console.WriteLine("Five.");
                    break;
                case 6:
                    Console.WriteLine("Six.");
                    break;
                case 7:
                    Console.WriteLine("Seven.");
                    break;
                case 8:
                    Console.WriteLine("Eight.");
                    break;
                case 9:
                    Console.WriteLine("Nine.");
                    break;
                case 10:
                    Console.WriteLine("Ten.");
                    break;
                case 0:
                    Console.WriteLine("Zero.");
                    break;
            }
        } else{
            Console.WriteLine("That number is not in range.");
        }
    }
}