//С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа.
System.Console.WriteLine("Введите двухзначное число:");
int n=Convert.ToInt32(Console.ReadLine());
int a=n/10;
int b=n%10;
if (a>b) System.Console.WriteLine($"{a} больше");
if (b>a) System.Console.WriteLine($"{b} больше");
if (b==a) System.Console.WriteLine("Цифры идентичны");