// Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [210 235; 210 300], числа, имеющие ровно четыре различных натуральных делителя, не считая единицы и самого числа. Для каждого найденного числа запишите эти четыре делителя в четыре соседних столбца на экране с новой строки. Делители в строке должны следовать в порядке возрастания.

// Например, в диапазоне [10; 16] ровно четыре различных натуральных делителя имеет число 12, поэтому для этого диапазона вывод на экране должна содержать следующие значения:

// 2 3 4 6

int [] array = new int [27];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(210,236);
    if (array[i]%2==0 && array[i]%3==0 && array[i]%4==0 && array[i]%6==0)
    
    Console.WriteLine( array[i]);
    
    
}
Console.WriteLine();
int [] arr = new int [91];


for (int index = 0; index < arr.Length; index++)
{
    arr[index] = new Random().Next(210,300);
    if (array[index]%2==0 && array[index]%3==0 && array[index]%4==0 && array[index]%6==0)
    
    Console.WriteLine( array[index]);
    
    
    
}

    

             








// int n (int n)

// {
//     int k=0;
//     for(int index = 2; index < n; index++)
//     {
//         if (n%index==0) k++;
//         return k;
//     }
// }
// Console.WriteLine(n(13));




