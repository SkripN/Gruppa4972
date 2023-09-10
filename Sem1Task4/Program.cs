Console.WriteLine("Жду первое число: ");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду второе число: ");
int num2 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду третье число: ");
int num3 = int.Parse(Console.ReadLine () ?? "");
int numMax = num1;
if (num2 > numMax) numMax = num2 ;
if (num3 > numMax) numMax = num3 ;
Console.WriteLine($"Среди чисел <{num1}>, <{num2}> и <{num3}> максимальное <{numMax}>");

