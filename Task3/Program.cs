int NumberOfDay = 6;
if (NumberOfDay == 1 ||
    NumberOfDay == 2 ||
    NumberOfDay == 3 ||
    NumberOfDay == 4 ||
    NumberOfDay == 5)
{
    System.Console.WriteLine("Сегодня не выходной, к сожалению");
}
else if (NumberOfDay == 6 ||
         NumberOfDay == 7)
{
    System.Console.WriteLine("Ура, выходной");
}
else
{
    System.Console.WriteLine("Нужно ввести номер дня недели от 1 до 7");
}

