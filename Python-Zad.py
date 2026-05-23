# Zbiór zadań z podstaw programowania

def kalkulator():
    """Zadanie 1: Kalkulator"""
    print("Podaj pierwsza liczbe:")
    first_number = int(input())
    print("Podaj druga liczbe:")
    second_number = int(input())
    print("Podaj operator (+, -, /, *):")
    sign = input()

    match sign:
        case '+': result = first_number + second_number
        case '-': result = first_number - second_number
        case '*': result = first_number * second_number
        case '/': result = first_number / second_number
        case _:
            print("Nieprawidłowy operator.")
            return

    print(f"Wynik to: {result}")


def konwerter_temperatur():
    """Zadanie 2: Konwerter temperatur"""
    choice = input("Wybierz kierunek konwersji (C lub F): ").upper()
    temp = float(input("Podaj temperaturę: "))

    if choice == 'C':
        fahrenheit = temp * 1.8 + 32
        print(f"{temp}°C = {fahrenheit}°F")
    elif choice == 'F':
        celsius = (temp - 32) / 1.8
        print(f"{temp}°F = {celsius}°C")
    else:
        print("Nieprawidłowy wybór.")


def srednia_ocen():
    """Zadanie 3: Średnia ocen ucznia"""
    count = int(input("Podaj liczbę ocen: "))
    total = 0

    for i in range(1, count + 1):
        grade = float(input(f"Podaj ocenę {i}: "))
        total += grade

    average = total / count
    print(f"Średnia: {average:.2f}")

    if average >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def main():
    print("=== MENU ===")
    print("1. Kalkulator")
    print("2. Konwerter temperatur")
    print("3. Średnia ocen ucznia")
    choice = input("Wybierz zadanie (1-3): ")

    match choice:
        case '1': kalkulator()
        case '2': konwerter_temperatur()
        case '3': srednia_ocen()
        case _: print("Nieprawidłowy wybór zadania.")


if __name__ == "__main__":
    main()
    input("\nNaciśnij Enter, aby zamknąć program...")
