Console.WriteLine("Жду число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");
// Переберем все числа от 1 до числа numTest
int cur = 2;
Console.Write($"Четные числа от <1> до <{numTest}> :");  
while (cur < numTest)
{
    Console.Write($" {cur}");
    cur =cur +2;  
}    
Console.WriteLine("");
