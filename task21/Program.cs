// 21. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введете число");
int a = Convert.ToInt32(Console.ReadLine());
 int a1=a/10000%10000;
int a2= a/1000%1000%10 ;
int a4=a/10%10;
int a5=a%10;


if (a1==a5 && a2==a4)
Console.WriteLine("Число палиндромно: " +a);
else
Console.WriteLine("Число непалиндромно: " +a);