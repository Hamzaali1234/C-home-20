// tack 1
// try
// {
//  Console.Write("Введите первое число:");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите второе число:");
//  int b = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Результат: "+(double)a/b);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Oshibka");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Oshib:Divide by zero");
// }

// tack 2
// DateTime now = DateTime.Now;
// Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

// tack 3
// var Date = new DateTime(2025,05,15,12,00,10);
// var a = DateTime.Today-Date;
// System.Console.WriteLine(a.Days);

// tack 4
//    Console.Write("Number month (1-12): ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if (number >= 1 && number <= 12)
//    {
//        Month month = (Month)number;
//        Console.WriteLine("Month: " + month);
//    }
//    else
//    {
//        Console.WriteLine("Warning");
//    }

// tack 5
//  Console.Write("Color: ");
//  string input = Console.ReadLine();
//  if (Enum.TryParse(input, true, out Color color))
//  {
//      switch (color)
//      {
//  case Color.Красный:
//      Console.WriteLine("RGB(255, 0, 0)");
//      break;
//  case Color.Зеленый:
//      Console.WriteLine("RGB(0, 255, 0)");
//      break;
//  case Color.Синий:
//      Console.WriteLine("RGB(0, 0, 255)");
//      break;
//  default:
//      Console.WriteLine("Неправильный цвет!");
//      break;
//      }
//  }
//  else
//  {
//      Console.WriteLine("Неправильный цвет!");
//  }




   //    Home tack

// tack 1
// DateTime date = new DateTime(2016,8,16,3,57,32,11);
// Console.WriteLine("year = " + date.Year);
// Console.WriteLine("month = " + date.Month);
// Console.WriteLine("day = " + date.Day);
// Console.WriteLine("hour = " + date.Hour);
// Console.WriteLine("minute = " + date.Minute);
// Console.WriteLine("second = " + date.Second);
// Console.WriteLine("millisecond = " + date.Millisecond);

// tack 2
// int count = 0;
// while (true)
// {
//     string text = Console.ReadLine();

//     if (text == "end" || text == "охир")
//     {
//         break;
//     }
//     count++;
// }
// Console.WriteLine("Шумораи сатрҳо: " + count);

// tack 3
//  Gauge gauge = new Gauge();
// gauge.Enhance();
// gauge.Enhance();
// gauge.Enhance();
// Console.WriteLine(gauge.value);
// Console.WriteLine(gauge.Full());
// gauge.Decrease();
// Console.WriteLine(gauge.value);
// Console.WriteLine(gauge.Full());