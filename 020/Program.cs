/*Определить номер четверти плоскости, 
в которой находится точка с координатами Х и У, 
причем X ≠ 0 и Y ≠ 0
*/
System.Console.WriteLine("Введите координату X:");
double x=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:");
double y=Convert.ToDouble(Console.ReadLine());

if(x>0 && y>0) System.Console.WriteLine("Точка находится в первой четверти.");
if(x<0 && y>0) System.Console.WriteLine("Точка находится во второй четверти.");
if(x<0 && y<0) System.Console.WriteLine("Точка находится в третьей четверти.");
if(x>0 && y<0) System.Console.WriteLine("Точка находится в четвертой четверти.");