// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string numberOneStr = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string numberTwoStr = Console.ReadLine();

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo = Convert.ToInt32(numberTwoStr);

if (numberOne > numberTwo)
{
    Console.WriteLine(numberOne);
}
else
    Console.WriteLine(numberTwo);