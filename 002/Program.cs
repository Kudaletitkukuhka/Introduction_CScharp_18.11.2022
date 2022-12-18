//С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
System.Console.WriteLine("Введите два вещественных числа:");
double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());
if (a*a==b) 
{
     System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a) 
{
     System.Console.WriteLine($"{a} является квадратом {b}");
}