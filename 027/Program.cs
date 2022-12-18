// Возведите число А в натуральную степень B используя цикл
int Stepen(int a,int b)
{
     int stp=a;
     for(int i=1;i<b;i++)
     {
          stp=stp*a;
     }
     return stp;
}

System.Console.WriteLine("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int B=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Stepen(A,B));