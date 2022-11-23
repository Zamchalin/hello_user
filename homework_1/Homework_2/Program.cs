Console.Write("Введите пожалуйста первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите пожалуйста второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите пожалуйста третье  число: ");
int c = int.Parse(Console.ReadLine());
if (a > b && a > c)
    Console.Write($"{a} это cамое большое число");
else if (b > a && b > c)
    Console.Write($"{b} это самое большое число");
else if (c > a && c > b)
    Console.Write($"{c} это самое большое число");
else if (a == b && b > c)
     Console.Write($"{a} это cамое большое число");
else if (b == c && b > a)
     Console.Write($"{b} это cамое большое число");
 else if (a == c && c > b)
     Console.Write($"{c} это cамое большое число");
else if (a == c && c == b)
     Console.Write("Числа равны");
