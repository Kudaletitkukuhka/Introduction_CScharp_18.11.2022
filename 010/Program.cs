// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.WriteLine("Введите целое число:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Последняя цифра вашего числа {a%10}.");