//Вывести на экран таблицу квадратов чисел от 1 до N
/* Без подпрограмм
System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N; i++)
{
     int qud=i*i;
     System.Console.WriteLine($"{i} в квадрате равен {qud}");
}
*/

string Qud(int a)
{
     int i=1;
     string result=String.Empty;
     while (i<=a)
     {
     result=result+($"{i} в квадрате равно {i*i}; \n");
     i++;
     }
     return result;
}

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Qud(N));