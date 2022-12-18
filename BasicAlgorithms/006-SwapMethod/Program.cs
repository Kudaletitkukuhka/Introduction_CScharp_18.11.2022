//Обмен значений

void Swap(ref int a, ref int b)
{
     int t = a;
     a = b;
     b = t;
}

int a=3,b=4;
System.Console.WriteLine($"a={a}, b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a}, b={b}");