// 34 Написать программу замену элементов массива на противоположные

int [] array = new int [8];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write($" {array[i]} " );
}
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * - 1;;
    Console.Write( $" {array[i]} " );

}

