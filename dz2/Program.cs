/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNamber1 = int.Parse(userInput1);
int userNamber2 = int.Parse(userInput2);
if (userNamber1 > userNamber2)
  {
    Console.WriteLine($"a={userNamber1}, b={userInput2} -> max ={userNamber1}");
  }
else
{
    Console.WriteLine($"a={userNamber1}, b={userInput2} -> max ={userNamber2}");
}