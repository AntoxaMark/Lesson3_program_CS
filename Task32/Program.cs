//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int[] array = {0,0,0,0,1,1,1,1};
int[] array = new int[8];
int index = 0;
while (index < 8)
{
    array[index] = new Random().Next(0,2);
    index++;
}
index = 0;
while (index < 8)
{
    Console.WriteLine(array[index]);
    index++;
}
