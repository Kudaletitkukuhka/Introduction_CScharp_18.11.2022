//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.WriteLine("Введите целое число:");
int a=Convert.ToInt32(Console.ReadLine());
int n=a/100%10;
if (n!=0) 
{
     System.Console.WriteLine($"В этом числе на третьем месте стоит {n}.");
}
else System.Console.WriteLine("NO");