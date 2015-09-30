using System;
using System.Collections.Generic;

class Program
{

    private string name;

    private int number;

    private string propertyExample { get; set; }

    private string text = "This is some text ";

    public void Run()
    {
        /*
        Console.WriteLine("Input name: ");
        name = Console.ReadLine();
        Console.WriteLine("Name: " + name);
        
        
        Console.WriteLine("Input number: ");
        //number = int.Parse(Console.ReadLine());

        int numberCheck;
        if(int.TryParse(Console.ReadLine(), out numberCheck) == true)
        {
            number = numberCheck;
        }

        Console.WriteLine("Number: " + number);
        
        
        //Input Conditional Experiment
        string text;
        text = Console.ReadLine();
        if (text == "Y" || text == "y")
        {
            Console.WriteLine("You have selected Yes");
        }
        else if (text == "N" || text == "n")
        {
            Console.WriteLine("You have selected No");
        }
        else
        {
            Console.WriteLine("Invalid Selection");
        }
         

        string newString;
        newString = "Your name is " + name + " and your number is " + number.ToString();
        Console.WriteLine(newString);
        */
        //welcomeMessage();
        //Console.WriteLine("New number " + multiplyByTen(number));
        //Console.WriteLine(getSomeText(text));
        Console.WriteLine(calculation(17, 153, 13678));
        
    }

    private int calculation(int a, int b, int c)
    {
        if (a >= b){
        return c;
    }
    else if (c > b * a)
    {
        return c * b;
    }
    else
    {
        return a;
    }
}

    private void welcomeMessage()
    {
        Console.WriteLine("Greetings");
    }

    private int multiplyByTen(int thisNumber)
    {
        return thisNumber * 10;
    }

    private string getSomeText(string text)
    {
        text = text + Console.ReadLine();
        return text;
    }
    // 4 - LERP
    /*
    private float lerp(float v0, float v1, float t)
    {
        return v0 * (v1 - v0) + t;
    }
     */
}
