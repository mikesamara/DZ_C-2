System.Console.WriteLine("Введите трехначное число");
int a = Convert.ToInt32(Console.ReadLine());
int firstnumber = a % 100;
int secondnumber = a % 10;
int b = (firstnumber - secondnumber) / 10;
System.Console.WriteLine(b);