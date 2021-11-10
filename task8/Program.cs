// 8. Показать четные числа от 1 до N

int [] array = {1,2,3,4,5,6,7,8,9,10,11};
int i =0; 
while (i<11)
{
     Console.WriteLine(array[i]);
     i++;
}
int index=0;
Console.WriteLine();
int z = array[0];
while (index < 11)
{
     if (array[index]%2 == 0) 
     {
         Console.WriteLine(array[index]);
         z = array[index];

     }
     index++;

}