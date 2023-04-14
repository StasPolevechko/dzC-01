/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNamber = int.Parse(userInput);
for (int i = 1; i <= userNamber; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"  {i + ","} ");
    }
}