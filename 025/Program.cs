//Вывести на экран кубы чисел от 1 до N
string Qud(int a)
{
     int i=1;
     string result=String.Empty;
     while (i<=a)
     {
     result=result+($"{i} в кубе равно {i*i*i}; \n");
     i++;
     }
     return result;
}

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Qud(N));