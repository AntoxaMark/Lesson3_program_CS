// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int [] array = new int [5];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.WriteLine(array[i]);
}

int myNumber; 

 myNumber = Convert.ToInt32 (Console.ReadLine());
for (int index = 0; index < array.Length; index++)
{
 if ( array[index] == myNumber )
 

Console.WriteLine("Присутствует данное число " +myNumber);

else 
Console.WriteLine("Отсутсвует");



}







