//static void DayOffWeek(int dayWeek);
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case 1:
          Console.WriteLine("Понельник-НЕТ");
          break;
        case 2:
          Console.WriteLine("Вторник-НЕТ");
          break;
        case 3:
          Console.WriteLine("Среда-НЕТ");
          break;
        case 4:
          Console.WriteLine("Четверг-НЕТ");       
          break;
        case 5:
          Console.WriteLine("Пятница-НЕТ");
          break;
        case 6:
          Console.WriteLine("Суббота-ДA! Выходной!"); 
          break;      
        case 7:
          Console.WriteLine("Воскресенье-ДA! Выходной!");
          break;
        default:
          Console.WriteLine("Число больше 7 или меньше 1");
          break;
    }