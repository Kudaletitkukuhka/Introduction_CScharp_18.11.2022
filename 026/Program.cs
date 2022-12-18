//Найти сумму чисел от 1 до А.
int Sum(int a)
{
     int result=0;
     for(int i=1;i<=a;i++)
     {
          result=result+i;
     }
     return result;
}

System.Console.WriteLine("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(A));