// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int [] array = new int [20];
int ThisNumbers;

for (int index=0;index<array.Length;index++)
{
    array[index] = new Random().Next(1,99);
    Console.WriteLine(array[index]);

}
Console.WriteLine("Введите Число");
ThisNumbers = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (array[i]  == ThisNumbers)
    Console.WriteLine("В массиве присутсвует" +ThisNumbers);
    else 
    Console.WriteLine("Числа в массие нет");
}

