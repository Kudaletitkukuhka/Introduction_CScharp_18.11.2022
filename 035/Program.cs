//Написать программу замены элементов массива на противоположные

int[] RandomArray(int size=10,int min=1,int max=10)
{
     int[] a=new int [size];
     Random random=new Random();
     for(int i=0;i<size;i++)
          a[i]=random.Next(min,max+1);
     return a;
}

int[] ChangeNumbersInArray(int[] a)
{
     for(int i=0; i<a.Length/2; i++)
          {
             int temp=a[i];
             a[i]=a[^(1+i)];
             a[^(1+i)]=temp;
          }
     return a;    
}

void PrintArray(int[] array)
{
for(int i=0; i<array.Length;i++) System.Console.Write($"{array[i]} ");
}

System.Console.WriteLine("Укажите количество элементов будущего массива:");
int N=Convert.ToInt32(Console.ReadLine());
int[] array=RandomArray(N,1,10);
PrintArray(array);

System.Console.WriteLine();

int[] newArray=ChangeNumbersInArray(array);
PrintArray(newArray);
