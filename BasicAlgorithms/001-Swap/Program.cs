//Обмен значения двух переменных
/*Классический способ
int a=5;
int b=9;
int temp;
temp=a;
a=b;
b=a;
*/
//Без третьей переменной
int a=5;
int b=10;
a=a+b;
b=a-b;
a=a-b;