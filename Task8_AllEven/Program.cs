Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine());
String result = "";
for (int index = 2; index <= numberN; index += 2)
{
    result += Convert.ToString(index);
    result += " ";
}
Console. Write(result);