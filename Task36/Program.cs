// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] array = new int [8];
int count = 0;
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.WriteLine(array[i]);
 
}

for (int inp = 0; inp < array.Length; inp++)
{
    if ((array[inp] % 2) == 0)
{   count++;
    
} 
}
Console.WriteLine(count);



