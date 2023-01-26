System.Console.WriteLine("Веедите день недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 1 && a < 6)
{
    System.Console.WriteLine("не выходной день");
}

else if (a > 5 && a <= 7)
{
    System.Console.WriteLine("Выходной день");
}
else 
{
    System.Console.WriteLine("Такого дня недели не сущесвует");
}