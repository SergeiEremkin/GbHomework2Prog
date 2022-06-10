int NumberOfDay;
while (true)
{
    System.Console.WriteLine("Введите номер дня недели");
    NumberOfDay = Convert.ToInt32(Console.ReadLine());
    if (NumberOfDay <= 7 && NumberOfDay >= 1)
    {
        break;
    }
}
if (NumberOfDay == 1 || NumberOfDay == 2 || NumberOfDay == 3 || NumberOfDay == 4 || NumberOfDay == 5)
    System.Console.WriteLine("Это будний день");
else
    System.Console.WriteLine("Это выходной день");



    
    

        
    
