//Определить, присутствует ли в заданном массиве, некоторое число

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

int LinearSearch(int[] m, int find)
{
     int i=0;
     while(i<m.Length && m[i]!=find) i++;
     if (i==m.Length) return -1;
     else return i;
}


int[] m=RandomArray();
Print(m);
System.Console.WriteLine();
System.Console.WriteLine("Введите число для поиска в массиве:");
int find=Convert.ToInt32(Console.ReadLine());
int i=LinearSearch(m,find);
if(i==-1)
     System.Console.WriteLine($"Числа {find} нет в массиве");
else 
     System.Console.WriteLine($"Число {find} находится на позиции с индексом {i}");