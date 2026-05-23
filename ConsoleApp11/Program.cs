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
            ////Opis: Napisz program, który prosi użytkownika o dwie liczby oraz o wybór operacji arytmetycznej (+, -, * lub /). Następnie, w zależności od wybranego działania, program oblicza wynik i wyświetla go na ekranie. Użyj instrukcji warunkowej (if/elif) do rozpoznania operacji.
            //Przykład:
            //Wejście: 10, 20, +
            //Wyjście: Wynik: 30

            //Z uwagi na to że wskazane liczby w przykładzie nie posiadaja przecinka dalem same inty
            // Zad 1.
            int first_number, second_number, result=-1;
            char mathematical_sign;
            char[] tab = { '+', '-', '/', '*' };

            Console.WriteLine("Witaj w zadaniu 1");
            Console.WriteLine("Podaj pierwsza liczbe");
            first_number = int.Parse((Console.ReadLine()));
            Console.WriteLine("Podaj druga liczbe");
            second_number = int.Parse((Console.ReadLine()));
            Console.WriteLine("Podaj operator (+, -, /, *)");
            mathematical_sign = char.Parse((Console.ReadLine()));
            

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
        }
    }
}
