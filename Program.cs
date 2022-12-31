string DecToBin(int n)
{
    string b = "";
    if (n > 0)
        b += DecToBin(n / 2) + (n % 2);
    return b;

}
Console.WriteLine("Input number : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number in binary system: ");
Console.WriteLine(DecToBin(n));