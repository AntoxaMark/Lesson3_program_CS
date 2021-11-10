//1. По двум заданным числам проверять является ли первое квадратом второго
int a;
int b;
Console.WriteLine("1-ое число");
string kek = Console.ReadLine ();      //или чтобы не воодить новую переменную, можно описать так a = Convert.ToInt32(Console.ReadLine());
a = Convert.ToInt32(kek);
Console.WriteLine("Ввудите 2-ое число");
string c = Console.ReadLine ();
b = Convert.ToInt32(c);
if (a==b*b) Console.WriteLine ("Да, является");
else Console.WriteLine("Нет,не является");

