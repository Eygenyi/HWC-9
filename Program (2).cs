int SumNumb(int n, int m)
{
    if (n <= m)
        return SumNumb(n + 1, m) + n;
    else return 0;

}
Console.WriteLine("Input first number : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number : ");
int m = Convert.ToInt32(Console.ReadLine());

if (SumNumb(n, m) == 0)
    Console.WriteLine("Error");
else
    Console.WriteLine("Sum between two numbers is : " + SumNumb(n, m));