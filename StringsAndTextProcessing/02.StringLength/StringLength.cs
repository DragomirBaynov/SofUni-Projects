using System;

class StringLength
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int length = input.Length;
        string result = "";    
        if (length < 20)
        {
            
            result = input.PadRight(20,'*');
            Console.WriteLine(result);
        }
        if (length>20)
        {
            Console.WriteLine(input.Substring(0,20));
        }
    }
}

