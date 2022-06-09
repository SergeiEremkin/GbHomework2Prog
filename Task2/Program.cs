int N = 12;
int CountOfNumbers = 0;
int Temp = N;
while (Temp != 0)
{
    Temp = Temp / 10;
    CountOfNumbers++;
}
Console.WriteLine(CountOfNumbers);
if (CountOfNumbers >= 3)
{
    while (CountOfNumbers != 3)
    {
        N = N / 10;
        CountOfNumbers--;
    }
    int Result = N % 10;
    System.Console.WriteLine(Result);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

