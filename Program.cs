int a = Convert.ToInt32(Console.ReadLine());

if (a<0) 
{
    Console.WriteLine("Номер не день недели");
    return;
}
else if (a>7)
{
    Console.WriteLine("Номер не день недели");
    return;
}
else
{
    if(a==6)
    {
        Console.WriteLine("Да");
        return;
    }
    else if(a==7)
    {
        Console.WriteLine("Да");
        return;
    }
    else
    {
        Console.WriteLine("Нет");
        return;
    }
}