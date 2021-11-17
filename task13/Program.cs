//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


int [] arr = new int [1];
int i=0;
int a;
arr[i] = new Random().Next (2,1000);
Console.WriteLine(arr[i]);
Console.WriteLine ("Ведите число ");
a = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < arr.Length; index++)
{
    if (arr[index]%a==0)
    Console.WriteLine ("Число кратно заданному");
    else 
    Console.WriteLine("Число некратно заданному");
}