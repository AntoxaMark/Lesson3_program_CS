//Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите техзначное число");
int b, a;
a = Convert.ToInt32(Console.ReadLine());

b = a / 100 * 10 + a % 10;
Console.WriteLine("Число  " + b);