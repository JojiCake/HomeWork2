// Можно сделать по другому:
// if (number < 6)
// {Console.Writeline("Нет");}
// if (number >5)
// {Console.WriteLine("Да! ")}



Console.WriteLine("Введите цифру дня недели: ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if(number == 1)
{
    Console.WriteLine("Понедельник - не выходной :( ");
}
if(number == 2)
{
    Console.WriteLine("Вторник - не выходной :( ");
}
if(number == 3)
{
    Console.WriteLine("Среда - не выходной :(");
}
if(number == 4)
{
    Console.WriteLine("Четверг - не выходной :( ");
}
if(number == 5)
{
    Console.WriteLine("Пятница - не выходной :( ");
}
if(number == 6)
{
    Console.WriteLine("Суббота - выходной!");
}
if(number == 7)
{
    Console.WriteLine("Воскресенье - выходной!");
}
Console.WriteLine();