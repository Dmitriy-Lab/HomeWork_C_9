// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

string Factorial(int m, int n)
{
    if (m <= n) return ($"{m} " + Factorial(m + 1, n));
    else return String.Empty;
}
Console.WriteLine(Factorial(numberM, numberN));