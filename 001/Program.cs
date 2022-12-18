//С клавиатуры вводится целое число. Выводится квадрат этого числа.
int a;
System.Console.Write("Введите число:");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine($"{a}^2={b}");