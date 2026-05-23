using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.Write("Wybierz zadanie (1-3): ");
            int taskChoice = int.Parse(Console.ReadLine());

            switch (taskChoice)
            {
                case 1:
                    // Zadanie 1: Kalkulator
                    int first_number, second_number, result = -1;
                    char mathematical_sign;
                    char[] tab = { '+', '-', '/', '*' };

                    Console.WriteLine("Podaj pierwsza liczbe");
                    first_number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj druga liczbe");
                    second_number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj operator (+, -, /, *)");
                    mathematical_sign = char.Parse(Console.ReadLine());

                    foreach (char sign in tab)
                    {
                        if (mathematical_sign == sign)
                        {
                            switch (sign)
                            {
                                case '+': result = first_number + second_number; break;
                                case '-': result = first_number - second_number; break;
                                case '*': result = first_number * second_number; break;
                                case '/': result = first_number / second_number; break;
                            }
                        }
                    }
                    Console.WriteLine("Wynik to: " + result.ToString());
                    break;

                case 2:
                    // Zadanie 2: Konwerter temperatur
                    Console.Write("Wybierz kierunek konwersji (C lub F): ");
                    char choice = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    Console.Write("Podaj temperaturę: ");
                    double temp = double.Parse(Console.ReadLine());

                    if (choice == 'C')
                    {
                        double fahrenheit = temp * 1.8 + 32;
                        Console.WriteLine($"{temp}°C = {fahrenheit}°F");
                    }
                    else if (choice == 'F')
                    {
                        double celsius = (temp - 32) / 1.8;
                        Console.WriteLine($"{temp}°F = {celsius}°C");
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy wybór.");
                    }
                    break;

                case 3:
                    // Zadanie 3: Średnia ocen ucznia
                    Console.Write("Podaj liczbę ocen: ");
                    int count = int.Parse(Console.ReadLine());
                    double sum = 0;

                    for (int i = 1; i <= count; i++)
                    {
                        Console.Write($"Podaj ocenę {i}: ");
                        double grade = double.Parse(Console.ReadLine());
                        sum += grade;
                    }

                    double average = sum / count;
                    Console.WriteLine($"Średnia: {average:F2}");

                    if (average >= 3.0)
                        Console.WriteLine("Uczeń zdał.");
                    else
                        Console.WriteLine("Uczeń nie zdał.");
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór zadania.");
                    break;
            }
        }
    }
}