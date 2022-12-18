/*С клавиатуры вводится день, обозначающий день недели
Определить день недели*/

int day=2;

/* Неэффективный метод
if (day==1) System.Console.WriteLine("Понедельник");
if (day==2) System.Console.WriteLine("Вторник");
if (day==3) System.Console.WriteLine("Среда");
if (day==4) System.Console.WriteLine("Четверг");
if (day==5) System.Console.WriteLine("Пятница");
if (day==6) System.Console.WriteLine("Суббота");
if (day==7) System.Console.WriteLine("Воскресенье");
*/


switch(day)
{
     case 1:
          System.Console.WriteLine("Понедельник");
          break;
     case 2:
          System.Console.WriteLine("Вторник");
          break;
     case 3:
          System.Console.WriteLine("Среда");
          break;
     case 4:
          System.Console.WriteLine("Четверг");
          break;
     case 5:
          System.Console.WriteLine("Пятница");
          break;
     case 6:
          System.Console.WriteLine("Суббота");
          break;
     case 7:
          System.Console.WriteLine("Воскресенье");
          break;
     default:
          System.Console.WriteLine("Неправильный");
          break;
}