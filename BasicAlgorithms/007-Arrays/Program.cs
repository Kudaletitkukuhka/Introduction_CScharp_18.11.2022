//Рассчитать среднюю температуру
int N=7;//переменная для определения разера массива
int[] temp; //неприсвоенные значения/null
temp=new int[N];//создаем массива, то есть в temp помещается адрес массива
double s=0;

//заполнение массива
for(int i=0; i<N; i++)
     temp[i]=Convert.ToInt32(Console.ReadLine());

//обработка массива
for(int i=0;i<N;i++)
     s=s+temp[i];

//вывод результата
System.Console.WriteLine(s/N);
