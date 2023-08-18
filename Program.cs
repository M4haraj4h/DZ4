int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(a.ToString().Length);

if (b<3)
{
    Console.WriteLine("Число меньше чем трёхзначное");
    return;
}
else if (b>3)
{
    Console.WriteLine("Число больше чем трёхзначное");
    return;
}
else if (b==3)
{
    a = a/10;
    a = a % 10;
    Console.WriteLine(a);
}