/*Дано число обозначающее день недели. 
Выяснить является номер дня недели выходным*/
System.Console.WriteLine("Введите номер дня недели:");
int a=Convert.ToInt32(Console.ReadLine());
if (a>0 && a<8) 
{
     if (a<6) System.Console.WriteLine("Это рабочий день!");
     else System.Console.WriteLine("Ура! Выходной!");
}
else System.Console.WriteLine("Попробуйте еще раз");