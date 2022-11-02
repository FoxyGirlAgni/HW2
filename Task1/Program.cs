System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (num > 99 && num < 1000)
{
    res = num/10;
    res = res%10;
    System.Console.WriteLine($"{num} -> {res}");
}
else 
{
    System.Console.WriteLine("Число не является трёхначным");
}