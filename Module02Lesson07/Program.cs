// Module 02, Lesson 07

// Exercise 01

int val1 = 5;
int val2 = 5;

if (val1 == val2)
    Console.WriteLine($"{val1} i {val2} są równe");


// Exercise 02

Console.Write("Sprawdź czy liczba jest parzysta czy nieparzysta: ");
int value = Int32.Parse(Console.ReadLine());


if (value % 2 == 0)
    Console.WriteLine($"{value} jest liczbą parzystą");
else
    Console.WriteLine($"{value} jest liczbą nieparzystą");


// Exercise 03

Console.Write("Sprawdź jaką to liczba: ");
int valueCheck = Int32.Parse(Console.ReadLine());

if (valueCheck < 0)
    Console.WriteLine($"{valueCheck} jest liczbą ujemną.");
else if (valueCheck == 0)
    Console.WriteLine($"{valueCheck} jest liczbą neutralną.");
else
    Console.WriteLine($"{valueCheck} jest liczbą dodatnią.");


// Exercise 04

Console.Write("Jaki to rok: ");
int year = Int32.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    Console.WriteLine($"{year} jest rokiem przestępnym.");
else
    Console.WriteLine($"{year} nie jest rokiem przestępnym.");


// Exercise 05

Console.Write("Podaj swój wiek: ");
int age = Int32.Parse(Console.ReadLine());

if (age >= 35)
    Console.WriteLine("Możesz zostać posłem, premierem senatorem lub też wystartować w wyborach prezydenckich.");
else if (age >= 30)
    Console.WriteLine("Możesz zostać posłem, premierem lub senatorem.");
else if (age >= 21)
    Console.WriteLine("Możesz zostać posłem lub premierem.");
else
    Console.WriteLine("Jesteś za młody aby pełnić ważne funkcje w Państwie.");


// Exercise 06

Console.Write("Podaj swój wzrost w cm: ");
double height = double.Parse(Console.ReadLine());

if (height > 200)
    Console.WriteLine("Wzrost Everestowy - Wystarczający by zdobyć Mount Everest.");
else if (height <= 200 && height >= 170)
    Console.WriteLine("Wzrost Drabinkowy - dosięgasz do najwyższej półki w sklepie.");
else if (height < 170 && height >= 150)
    Console.WriteLine("Wzrost Kieszonkowy - śmiało zmieścisz się do kieszeni.");
else if (height < 150 && height >= 130)
    Console.WriteLine("Jesteś krasnoludem.");
else
    Console.WriteLine("Spróbuj podrosnąć aby załapać się na jakąś kategorię");


// Exercise 07

Console.WriteLine("Po podaniu 3 wartości - wskażę największą!");
Console.Write("Podaj wartość A: ");
int valA = Int32.Parse(Console.ReadLine());
Console.Write("Podaj wartość B: ");
int valB = Int32.Parse(Console.ReadLine());
Console.Write("Podaj wartość C: ");
int valC = Int32.Parse(Console.ReadLine());

int greatestValue = 0;

if (valA > greatestValue)
{
    greatestValue = valA;
    Console.WriteLine($"{greatestValue} jest największe!");
}
else if (valB > greatestValue)
{
    greatestValue = valB;
    Console.WriteLine($"{greatestValue} jest największe!");
}
else if (valC > greatestValue)
{
    greatestValue = valC;
    Console.WriteLine($"{greatestValue} jest największe!");
}
else
    Console.WriteLine("Podane wartości są równe.");


// Exercise 08

Console.WriteLine("Podaj swoje wyniki z Matury a dowiesz się czy zostaniesz dopuszczony do rekrutacji!");
Console.Write("Podaj swój wynik z matematyki: ");
int maths = Int32.Parse(Console.ReadLine());
Console.Write("Podaj swój wynik z fizyki: ");
int physics = Int32.Parse(Console.ReadLine());
Console.Write("Podaj swój wynik z chemii: ");
int chemistry = Int32.Parse(Console.ReadLine());

int totalPoints = maths + physics + chemistry;

if (maths > 70 && physics > 55 && chemistry > 45 && totalPoints > 170)
{
    Console.WriteLine($"Suma Twoich punktów wynosi: {maths + physics + chemistry}");
    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
}
else if (maths + physics > 150 || maths + chemistry > 150)
{
    Console.WriteLine($"Suma Twoich punktów wynosi: {maths + physics + chemistry}");
    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
}
else
{
    Console.WriteLine($"Suma Twoich punktów wynosi: {maths + physics + chemistry}");
    Console.WriteLine("Niestety - nie zostałeś dopuszczony do rekrutacji. Popraw swój wynik."); 
}


// Exercise 09

Console.Write("Podaj temperaturę aby sprawdzić w jakim jest przedziale: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp < 0)
    Console.WriteLine("Cholernie piździ.");
else if (temp >= 0 && temp < 10)
    Console.WriteLine("Zimno.");
else if (temp >= 10 && temp < 20)
    Console.WriteLine("Chłodno.");
else if (temp >= 20 && temp < 30)
    Console.WriteLine("W sam raz.");
else if (temp >= 30 && temp < 40)
    Console.WriteLine("Zaczyna byś słabo, bo gorąco.");
else
    Console.WriteLine("A weź wyprowadź się na Alaskę.");


// Exercise 10

Console.WriteLine("Podaj trzy wartości a sprawdzę czy można z nich stworzyć trójkąt.");
Console.Write("Podaj pierwszą wartość: ");
double sideA = double.Parse(Console.ReadLine());
Console.Write("Podaj drugą wartość: ");
double sideB = double.Parse(Console.ReadLine());
Console.Write("Podaj trzecią wartość: ");
double sideC = double.Parse(Console.ReadLine());

if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
    Console.WriteLine("Z podanych wartości powstanie trójkąt!");
else
    Console.WriteLine("Z podanych wartości nie powstanie trójkąt.");


// Exercise 11

Console.Write("Wpisz otrzymaną ocenę w postaci cyfry: ");
int grade = Int32.Parse(Console.ReadLine());

switch (grade)
{
    case 6:
        Console.WriteLine("Celujący");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 1:
        Console.WriteLine("Niedostateczny");
        break;
    default:
        Console.WriteLine("Oceny są w przedziale od 1 - 6");
        break;
}


// Exercise 12

Console.Write("Wpisz numer dnia tygodnia aby wyświetlić jego nazwę: ");
int weekDay = Int32.Parse(Console.ReadLine());

switch (weekDay)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Mamy 7 dni tygodnia. Podaj cyfrę od 1 do 7.");
        break;
}

// Exercise 13

Console.WriteLine("Możliwe operacja do wykonania:\n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie");
Console.Write("Wybierz operację: ");

int operation = Int32.Parse(Console.ReadLine());

Console.Write("Podaj pierwszą liczbę: ");
double value1 = double.Parse(Console.ReadLine());

Console.Write("Podaj drugą liczbę: ");
double value2 = double.Parse(Console.ReadLine());

double result = 0;

if (operation == 1)
    result = value1 + value2;
else if (operation == 2)
    result = value1 - value2;
else if (operation == 3)
    result = value1 * value2;
else if (operation == 4)
{
    result = value1 / value2;
        if (value2 == 0)
            Console.WriteLine("Nie dzielimy przez 0");
    return;
}
else
    Console.WriteLine("Nieprawidłowy numer operacji.");

Console.WriteLine($"Wynik operacji = {result}");