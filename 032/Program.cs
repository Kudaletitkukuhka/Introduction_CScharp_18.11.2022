/* Задать массив из 8 целых элементов и вывести их на экран*/

int[] RandomArray(int size=10,int min=-100,int max=100)
{
     int[] a=new int [size];
     Random random=new Random();
     for(int i=0;i<size;i++)
          a[i]=random.Next(min,max+1);
     return a;
}

void Print(int[] a)
{
     for(int i=0;i<a.Length;i++)
     System.Console.Write($"{a[i],5}");
}

int[] a=RandomArray(8,-100,100);
Print(a);