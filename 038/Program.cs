/*В одномерном массиве из 123 чисел 
найти количество элементов из отрезка [10,99]*/


int[] RandomArray(int size=10,int min=-100,int max=100)
{
     int[] a=new int [size];
     Random random=new Random();
     for(int i=0;i<size;i++)
     a[i]=random.Next(min,max);
     return a;
}

void Print(int[] a)
{
     for(int i=0;i<a.Length;i++)
     System.Console.Write($"{a[i],5}");
}

int FindRange(int[] a)
{
    int range=0;
    foreach (int el in a)
    if (el>=10 && el<=99) range++;
    return range;
}

int[] m=RandomArray(123,-100,500);
Print(m);
System.Console.WriteLine();

System.Console.WriteLine($"Количество чисел в диапозоне от 10 до 99 включительно: {FindRange(m)}");