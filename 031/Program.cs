/*31. Сгенерировать 10 случайных чисел. 
Показать кубы тех чисел,
которые заканчиваются на четную цифру.*/
/*Без подпрограмм 
Random random=new Random();
for(int i= 0; i < 10; i++)
{
     int a=random.Next(1,100);
     int b=(int)Math.Pow(a,3);
     if (b%2==0)
     System.Console.WriteLine($"{a}, {b}");
}
*/
bool Test(int a)
{
   return (a%2==0);
}

Random random=new Random();
for(int i= 0; i < 10; i++)
{
     int a=random.Next(1,100);
     int b=(int)Math.Pow(a,3);
     if (Test(b))
     System.Console.WriteLine($"{a}, {b}");
}


