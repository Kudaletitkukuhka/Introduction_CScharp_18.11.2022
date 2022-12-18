//По заданному с клавиатуры номеру дня недели вывести его название.
System.Console.WriteLine("Введите число от 1 до 7:");
int n=Convert.ToInt32(Console.ReadLine());
if(n==1) System.Console.WriteLine("Эх, только понедельник");
if(n==2) System.Console.WriteLine("Это вторник");
if(n==3) System.Console.WriteLine("Это среда");
if(n==4) System.Console.WriteLine("Это четверг");
if(n==5) System.Console.WriteLine("Ура! Пятница!");
if(n==6) System.Console.WriteLine("Ну наконец-то суббота");
if(n==7) System.Console.WriteLine("Воскресенье");