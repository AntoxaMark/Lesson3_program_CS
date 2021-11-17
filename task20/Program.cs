// 20. Ввести номер четверти, показать диапазоны для возможных координат

int a;

Console.WriteLine("Введите четверть");
a = Convert.ToInt32(Console.ReadLine());
if (a == 1 )  Console.WriteLine ("Диапозон y=[0;+N] x=[0;+N]");
if (a == 2 )  Console.WriteLine ("Диапозон y=[0;+N] x=[0;-N]");
if (a == 3 )  Console.WriteLine ("Диапозон y=[0;-N] x=[0;-N]");
if (a == 4 )  Console.WriteLine ("Диапозон y=[0;-N] x=[0;+N]");


