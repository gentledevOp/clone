// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to EveryDay Caculator");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Substraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
int ans = int.Parse(Console.ReadLine());
if (ans == 1)
{
    Console.WriteLine("Pls enter your First Number");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Pls enter your Second Number");
    int second = int.Parse(Console.ReadLine());
    int third = first + second;
    Console.WriteLine($"The Addition of your numbers is {third}");
}
else if (ans == 2)
{
     Console.WriteLine("Pls enter your First Number");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Pls enter your Second Number");
    int second = int.Parse(Console.ReadLine());
    int third = first - second;
    Console.WriteLine($"The Substraction of your numbers is {third}");
}
else if(ans == 3)
{
     Console.WriteLine("Pls enter your First Number");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Pls enter your Second Number");
    int second = int.Parse(Console.ReadLine());
    int third = first * second;
    Console.WriteLine($"The Multiplication of your numbers is {third}");
}
else if (ans == 4)
{
     Console.WriteLine("Pls enter your First Number");
    int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Pls enter your Second Number");
    int second = int.Parse(Console.ReadLine());
    int third = first / second;
    Console.WriteLine($"The division of your numbers is {third}");
}
else
{
    Console.WriteLine("Invalid number");
}

