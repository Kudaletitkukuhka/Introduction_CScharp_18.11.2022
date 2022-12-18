//30. Написать программу вычисления произведения чисел от 1 до N.
int CompTo(int a)
{
     int comp=1;
     if (a>=1) for(int i=2;i<=a;i++) comp=comp*i;
     else comp=0;
     return comp;
}

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CompTo(N));