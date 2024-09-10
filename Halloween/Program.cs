using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        string input;
        
        while ((input = Console.ReadLine()) != null)
        {
            if (input.Length < 6)
                input = input.Insert(4, "0");

            try
            {
                DateTime inputDate = DateTime.ParseExact(input, "MMM dd", provider);

                if (inputDate == DateTime.ParseExact("OCT 31", "MMM dd", provider) || inputDate == DateTime.ParseExact("DEC 25", "MMM dd", provider))
                {
                    Console.WriteLine("yup");
                }
                else
                {
                    Console.WriteLine("nope");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", input);
            }
        }
    }
}