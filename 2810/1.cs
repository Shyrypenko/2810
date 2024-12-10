using System;

class NumberConverter
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select conversion direction:");
            Console.WriteLine("1. From decimal to binary");
            Console.WriteLine("2. From decimal to hexadecimal");
            Console.WriteLine("3. From binary to decimal");
            Console.WriteLine("4. From hexadecimal to decimal");
            Console.WriteLine("5. Exit");

            Console.Write("Enter option number: ");
            string option = Console.ReadLine();

            if (option == "5")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            try
            {
                switch (option)
                {
                    case "1":
                        int decimalNumber = int.Parse(input);
                        Console.WriteLine($"Result: {Convert.ToString(decimalNumber, 2)}");
                        break;

                    case "2":
                        decimalNumber = int.Parse(input);
                        Console.WriteLine($"Result: {Convert.ToString(decimalNumber, 16).ToUpper()}");
                        break;

                    case "3":
                        int binaryNumber = Convert.ToInt32(input, 2);
                        Console.WriteLine($"Result: {binaryNumber}");
                        break;

                    case "4":
                        int hexNumber = Convert.ToInt32(input, 16);
                        Console.WriteLine($"Result: {hexNumber}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Number exceeds the range of int.");
            }

            Console.WriteLine();
        }
    }
}