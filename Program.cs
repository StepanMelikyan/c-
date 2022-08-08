int A = 0;
int B = 0;

Console.WriteLine("Введите число А");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine(" максимальное число = " +A );
}
if (A < B)
{
    Console.WriteLine("B - максимальное число = " +B );
}
if (A == B)
{
    Console.WriteLine("числа равны друг другу");
}