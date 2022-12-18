//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
int SumDigits(int a)
{
  int sum=0;
  for(int i=1;a%10>0;i++)
  {
     int ost=a%10;
     sum=sum+ost;
     a=a/10;
  }
  return sum;
}

System.Console.WriteLine("Введите число: ");
int N=Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine(SumDigits(N));