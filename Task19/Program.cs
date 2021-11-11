// 19.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x,y;
Console.WriteLine("Введите координату x");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y");
y = Convert.ToInt32(Console.ReadLine());

{
if (x > 0 & y > 0) Console.WriteLine("Четверь № 1");
if (x < 0 & y > 0) Console.WriteLine("Четверь № 2");
if (x < 0 & y < 0) Console.WriteLine("Четверь № 3");
if (x > 0 & y < 0) Console.WriteLine("Четверь № 4");
}
