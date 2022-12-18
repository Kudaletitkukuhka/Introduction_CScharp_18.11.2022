System.Console.WriteLine("Введте 3 числа:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>max) max=b;
if (c>max) max=c;
System.Console.WriteLine($"{max} самое большое число.");