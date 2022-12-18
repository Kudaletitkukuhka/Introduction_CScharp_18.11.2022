/* Задать номер четверти, 
показать диапазоны для возможных координат
*/
System.Console.WriteLine("Введите номер четверти:");
int n=Convert.ToInt32(Console.ReadLine());
if (n>0 && n<5)
{
     if (n==1) System.Console.WriteLine("X(0;∞) Y(0;∞)");
     if (n==2) System.Console.WriteLine("X(-∞;0) Y(0;∞)");
     if (n==3) System.Console.WriteLine("X(-∞;0) Y(-∞;0)");
     if (n==4) System.Console.WriteLine("X(0;∞) Y(-∞;0)");
}
else System.Console.WriteLine("Попробуйте еще раз, нужно ввести число от 1 до 4.");