// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int [] array = new int [12];
int sum = 0;
int sum1 = 0;


for (int index = 0; index<array.Length; index++)
{
    array[index] = new Random().Next(-9,9);
    Console.WriteLine(array[index]);
    
    if (array[index]>0)
    {
        sum = sum +array[index];
    }
    else 
    {
        sum1 = sum1 + array[index];
    }
}
Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine();
Console.WriteLine(sum1);


