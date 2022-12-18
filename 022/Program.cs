// Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число");
int a=Convert.ToInt32(Console.ReadLine());
if (a>9999 && a<100000)
{
     if (a%10==a/10000%10 && a/10%10==a/1000%10)
     {
          System.Console.WriteLine("Число палиндром!:)");
     }
     else System.Console.WriteLine("Число не палиндром:(");
}
else System.Console.WriteLine("Вы ввели не пятизначное число");