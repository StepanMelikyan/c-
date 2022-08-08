int A = 0;
int B = 0;
int C = 0;
int maxnumber = 0;

Console.WriteLine("Введите число А");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
C = Convert.ToInt32(Console.ReadLine());
maxnumber = A;

if (B > maxnumber)
{
    maxnumber = B;
}
if (C > maxnumber)
{
    maxnumber = C;
}
Console.WriteLine("max = " +maxnumber);
