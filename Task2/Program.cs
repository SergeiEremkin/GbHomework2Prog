//вариант 1:
int N = 1246879;
int CountOfNumbers = 0;
int Temp = N;
while (Temp != 0)
{
    Temp = Temp / 10;
    CountOfNumbers++;
}
Console.WriteLine(CountOfNumbers); // Выводим кол-во цифр в числе
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

//вариант 2

// string Num;
// while (true)
// {
//     System.Console.WriteLine("Введите число"); 
//     Num = Console.ReadLine(); 
     
//     if (Num != null) 
//     {
//         if (Num.Length >= 3) 
//         {
//             break;
//         }
//     }
// }
// System.Console.WriteLine(Num[2]);



