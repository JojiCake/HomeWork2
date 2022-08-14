Console.WriteLine("Введите трёхзначное число:  ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);


int second = number % 100;

if(number < 1000)
{
    number = second / 10;
    Console.WriteLine( + number);
}
else
{
    Console.WriteLine("Чило не трёхзначное");
}
Console.WriteLine();