/*Алгоритм Евклида
int GCD(int a,int b)
{
     while(a!=b)
          if (a>b) 
          a=a-b; 
          else b=b-a;
          return a;
}
*/ 

//Алгоритм Евклида#2
int QuickGCD(int a,int b)
{
     while(a!=0 && b!=0)
          if (a>b) 
          a=a%b; 
          else b=b%a;
          return a+b;
}

System.Console.WriteLine("Введите два числа:");
int Number1=Convert.ToInt32(Console.ReadLine());
int Number2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Наибольший общий знаменатель: {QuickGCD(Number1,Number2)}");