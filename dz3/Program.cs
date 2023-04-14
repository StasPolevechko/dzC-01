/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
Console.Write("введите третье целое число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNamber1 = int.Parse(userInput1);
int userNamber2 = int.Parse(userInput2);
int userNamber3 = int.Parse(userInput3);
int max = userNamber1;
if (userNamber2 > max)
{
    max = userNamber2;
}
if (userNamber3 > max)
{
    max = userNamber3;
}
Console.WriteLine($"{userNamber1}, {userNamber2}, {userNamber3} -> {max}");