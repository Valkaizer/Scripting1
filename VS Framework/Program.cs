using System;
using System.Collections.Generic;

class Program
{
    private int number = 0;

    private List<string> randomWords = new List<string>();

    public void Run()
    {

        while(number < 5)
        {
            Console.WriteLine("Enter word number " + (number + 1) + ": ");
            number++;
            randomWords.Add(Console.ReadLine());
        }

        randomWords.Sort();

        foreach (string word in randomWords)
            Console.WriteLine(word);

       /* while(number < 10)
        {
            Console.WriteLine("Number is currently " + number);
            number++;
            Console.WriteLine("Press any key to proceed...");
            Console.ReadKey(); 
        }

        do
        {
            Console.WriteLine("Number is currently " + number);
            number++;
            Console.WriteLine("Press any key to proceed...");
            Console.ReadKey(); 
        } while (number < 10);

        Console.WriteLine("Please enter a valid number: ");
        int numberCheck;
        while (int.TryParse(Console.ReadLine(), out numberCheck) == false)
        {
            Console.WriteLine("Invalid Input! Please enter a vaild number: ");
        }
        number = numberCheck;
        Console.WriteLine("Number entered was " + number);*/
    }
}
