//С клавиатуры вводя два числа a и b. Найти максимальное из них.
System.Console.WriteLine("Введте 2 числа:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
if(a>b)
{
     System.Console.WriteLine($"{a} больше {b}.");
}
if(a<b)
{
     System.Console.WriteLine($"{b} больше {a}.");
}
if(a==b)
{
     System.Console.WriteLine("Вы ввели два одинаковых числа.");
}