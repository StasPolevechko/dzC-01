/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNamber = int.Parse(userInput);
if (userNamber %2 == 0)
{
    Console.WriteLine($"{userNamber} -> да");
}
else 
{
    Console.WriteLine($"{userNamber} -> нет");
}