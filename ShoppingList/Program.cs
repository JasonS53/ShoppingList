using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunProgram;
            RunProgram = true;

            Console.WriteLine("Welcome to the Grand Circus Market!");
            Console.WriteLine();

            Dictionary<string, double> price = new Dictionary<string, double>
            {
                {"Apple" , 0.75 },
                {"Strawberries", 2.29},
                {"Lemon", 0.59},
                {"Asparagus" , 1.99},
                {"Onion" , 0.65},
                {"Pumpkin" , 2.59},
                {"Ground Beef" , 4.79},
                {"Chicken" , 5.49},
                {"Pork Belly" , 7.59},
                {"6 pack beer" ,6.99},
                {"6 pack soda" ,3.99},
            };
            
            {
                List<double> prices = new List<double>();
                List<string> items = new List<string>();
                Console.WriteLine("Item            Price");
                Console.WriteLine("=====================");
                Console.WriteLine();

                while (RunProgram)
                
                {
                    foreach (KeyValuePair<string, double> kvp in price)
                    {
                        Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
                    }

                    Console.WriteLine("What item would you like to order? ");
                    string choice = Console.ReadLine();

                    if (price.ContainsKey(choice))
                    {
                        Console.WriteLine($"You chose {choice} at {price[choice]}.");
                        items.Add(choice);
                        prices.Add(price[choice]);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't have those.  Please try again.");
                        continue;
                    }
                    

                    Console.WriteLine("would you like to order anything else? (y/n)");
                    string yesno = Console.ReadLine();
                    if (yesno == "y")
                    {
                        //RunProgram == false;
                    }
                    else if (yesno == "n")
                    {
                        Console.WriteLine("Thanks for your order!");
                        Console.WriteLine("Here's what you got:");
                        double total = 0; 
                        for (int i = 0; i < items.Count; i++)
                        {                           
                            Console.WriteLine($"{items[i]}\t\t{ prices[i]}");
                            total += prices[i];
                        }
                        Console.WriteLine($"The total is {total} and the average price per item in order was {total / items.Count}.");
                        RunProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("that was not a valid entry, please choose y/n");
                    }
                }

                

                

               


            }
        }
    }
}
