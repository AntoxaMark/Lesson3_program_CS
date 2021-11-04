// 31. Задать массив из 8 элементов и вывести их на экран 

int[] array = new int[8];
int index = 0;
while (index < 8)
{
    array[index] = new Random().Next(1,100);
    index++;
}

index = 0;
while (index < 8)
{
Console.WriteLine(array[index]);
index++;
}