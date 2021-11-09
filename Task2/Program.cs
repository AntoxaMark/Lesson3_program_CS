// 2. Даны два числа. Показать большее и меньшее число

int a,b;

Console.WriteLine("введите 1-ое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2-ое число");
b = Convert.ToInt32(Console.ReadLine());
if (a>b) 
{
    Console.WriteLine("Большее число " + a);
}
else

    Console.WriteLine("меньшее число " + b);
