
// макс из 3-ёх чисел
int max (int a, int b, int c);

{
if ( a > b) return a; else return b;
if (a > c) return a; else return c;
if (b > c) return b; esle return c;
}
Console.WriteLine(max(1,2,3));

