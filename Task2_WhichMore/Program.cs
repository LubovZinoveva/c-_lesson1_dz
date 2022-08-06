Console.WriteLine("Введите два числа:");
double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine($"{numberA} > {numberB}");
}
else if (numberA < numberB) 
{
    Console.WriteLine($"{numberA} < {numberB}");
}
else 
{
    Console.WriteLine($"{numberA} = {numberB}");
}