Console.WriteLine("Напишите число");
int a = Convert.ToInt32(Console.ReadLine());

int ansver = a % 2;

if (ansver == 1)
    {
        Console.WriteLine("нет, число нечётное");
    }
else 
    {
        Console.WriteLine("да, число чётное");
    }
