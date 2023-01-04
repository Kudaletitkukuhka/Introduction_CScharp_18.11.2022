/*Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном массиве a. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/

int[] RandomArray(int size=10,int min=1,int max=10)
{
     int[] a=new int [size];
     Random random=new Random();
     for(int i=0;i<size;i++)
          a[i]=random.Next(min,max+1);
     return a;
}

int[] MultiplyPairArray(int[] a)
{
     int size=a.Length;
     int[] NewArray=new int[size];
     for(int i=0; i<size; i++) NewArray[i]=a[i]*a[a.Length-1-i];
return NewArray;    
}

void PrintArray(int[] array)
{
for(int i=0; i<array.Length;i++) System.Console.Write($"{array[i]} ");
}

int N=Convert.ToInt32(Console.ReadLine());
int[] array=RandomArray(N,1,10);
int[] newArray=MultiplyPairArray(array);

PrintArray(array);
System.Console.WriteLine();
PrintArray(newArray);