Console.Clear();
Console.WriteLine("Введите первое  число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a / b == b)
    Console.WriteLine("Yes");
else 
    Console.WriteLine("No");
