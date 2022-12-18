// Определить количество цифр в числе. Сделать подпрограмму.
/* Без подпрограмм
System.Console.WriteLine("Введите число:");
int n=Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
int i=0;
if (n==0) i=1;
while(n>0)
{
     n=n/10;
     i++;
}
System.Console.WriteLine(i);
*/

//Подпрограмма
int CountDigits(int Number)
{
     Number=Math.Abs(Number);
     int count=0;
     if (Number==0) count=1;
     while (Number>0)
     {
          Number=Number/10;
          count++;
     }
     return count;
}

//Программа
System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));