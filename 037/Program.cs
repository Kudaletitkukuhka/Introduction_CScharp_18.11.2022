/*Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечетных\четных чисел*/

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

int FindOdd(int[] a)
{
    int Odd=0;
    foreach (int el in a)
    if (el%2==0) Odd++;
    return Odd;
}

int FindEven(int[] a)
{
    int Even=0;
    foreach (int el in a)
    if (el%2!=0) Even++;
    return Even;
}


int[] m=RandomArray(10,100,999);
Print(m);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел массива равна {FindOdd(m)}");
System.Console.WriteLine($"Количество нечетных чисел массива равна {FindEven(m)}");