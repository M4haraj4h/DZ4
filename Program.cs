int a = Convert.ToInt32(Console.ReadLine());

if (a<100)
{
    Console.WriteLine("Третьего числа нет");
    return;
}
else if (a>999)
{
    while(a>999)
    {
        a = a / 10;
    }
}

a = a % 10;
Console.WriteLine(a);