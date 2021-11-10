
// макс из 3-ёх чисел
int a,b,c;



Console.WriteLine("Введите 1-ое чсило");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое чсило");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое чсило");
c = Convert.ToInt32(Console.ReadLine());
int z=a;
Console.WriteLine();
{
    if (b>z) z=b;
    if (c>z) z=c;
    
    
}
Console.WriteLine("Максимальное число" +z);



