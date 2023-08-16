using System;

namespace ControlStructure2
{
        class Program
        {
            static void Main(string[] args)
            {
                int totalTemperatures = 0;
                double totalTemperatureSum = 0;

                while (true)
                {
                    Console.Write("Enter a daily high temperature (20 - 130 Fahrenheit) or 'q' to quit: ");
                    string temperatureInput = Console.ReadLine();

                    if (temperatureInput.ToLower() == "q")
                    {
                        break;
                    }

                    if (double.TryParse(temperatureInput, out double temperature))
                    {
                        if (temperature >= 20 && temperature <= 130)
                        {
                            totalTemperatures++;
                            totalTemperatureSum += temperature;
                        }
                        else
                        {
                            Console.WriteLine("Temperature must be between 20 and 130 Fahrenheit.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid temperature or 'q' to quit.");
                    }
                }

                if (totalTemperatures > 0)
                {
                    double averageTemperature = totalTemperatureSum / totalTemperatures;
                    Console.WriteLine($"Number of temperatures entered: {totalTemperatures}");
                    Console.WriteLine($"Average temperature: {averageTemperature:F2} Fahrenheit");
                }
                else
                {
                    Console.WriteLine("No temperatures entered.");
                }
            }
        }

}