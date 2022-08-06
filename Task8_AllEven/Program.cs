Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
int i = 2;
String result = "";
while (i <= numberN)
{
    result += Convert.ToString(i);
    result += " ";
    i += 2;
}
Console. Write(result);