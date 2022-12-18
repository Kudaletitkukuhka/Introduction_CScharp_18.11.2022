//Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] RandomArray(int size=10,int min=-100,int max=100)
{
     int[] a=new int [size];
     Random random=new Random();
     for(int i=0;i<size;i++)
          a[i]=random.Next(min,max+1);
     return a;
}

int SunOddPosition(int[] a)
{
     int s=0;
     for(int i=0;i<a.Length;i+=2) 
          s=s+a[i];
     return s;
}

int SunEvenPosition(int[] a)
{
     int s=0;
     for(int i=1;i<a.Length;i+=2) s=s+a[i];
     return s;
}

void Print(int[] a)
{
     for(int i=0;i<a.Length;i++)
     System.Console.Write($"{a[i],5}");
}

int[] a=RandomArray(3,-5,5);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел с четным номером индекса: {SunOddPosition(a)}");
System.Console.WriteLine($"Сумма чисел с нечетным номером индекса: {SunEvenPosition(a)}");