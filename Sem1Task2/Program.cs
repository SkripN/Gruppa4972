//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Жду первое число: ");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду второе число: ");
int num2 = int.Parse(Console.ReadLine () ?? "");
if (num1 == num2) Console.WriteLine($"Число <{num1}> и <{num2}> равны ");
else if (num1 > num2) Console.WriteLine($"среди чисел <{num1}> и <{num2}> максимальное <{num1}>");
else Console.WriteLine($"Среди чисел <{num1}> и <{num2}> максимальное <{num2}>");
