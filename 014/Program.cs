//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Введите два числа:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int n=a%b;
if (n==0) 
{
     System.Console.WriteLine($"{a} кратно {b}.");
}
else 
{
     System.Console.WriteLine($"Остаток от деления {a} на {b} равен {n}");
}