// 27. Определить количество цифр в числе

int CountDigit (int n)
{
    int k=0;
    while (n!=0)
    {
        k++; // k=k=1;
        n=n/10;
    }
    return k;
}

Console.WriteLine(CountDigit(12345));