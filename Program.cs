//Задача1

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y = Convert.ToInt32(Console.ReadLine());

// if ((x>0)&&(y>0))
// {
//     Console.WriteLine("1");
// }

// else if ((x<0)&&(y>0))
// {
//     Console.WriteLine("2");
// }

// else if ((x<0)&&(y<0))
// {
//     Console.WriteLine("3");
// }

// else if ((x>0)&&(y<0))
// {
//     Console.WriteLine("4");
// }

//Задача2

//SWITCH!!!
// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0, y>0");
//         break;
//     }

//       case 2:
//     {
//         Console.WriteLine("x<0, y>0");
//         break;
//     }

//       case 3:
//     {
//         Console.WriteLine("x<0, y<0");
//         break;
//     }

//       case 4:
//     {
//         Console.WriteLine("x>0, y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Некорректное число");
//         break;
//     }
// }

//IF!!!
// if (num==1)
// {
//     Console.WriteLine("x>0, y>0");
// }

// else if (num==2)
// {
//     Console.WriteLine("x<0, y>0");
// }

// else if (num==3)
// {
//     Console.WriteLine("x<0, y<0");
// }

// else if (num==4)
// {
//     Console.WriteLine("x>0, y<0");
// }
// else
// {
//     Console.WriteLine("Некорректное число");
// }

//ЗАДАЧА3

// Console.WriteLine("Введите число");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow ((x2-x1),2)+ Math.Pow ((y2-y1),2));
// Console.WriteLine(d);

//ЗАДАЧА4

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while (num>=count)
// {
//     Console.WriteLine(Math.Pow (count,2));
//     count=count+1;
// }
//____________________ДОМАШНЕЕ ЗАДАНИЕ__________________________

//Задача1

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num<10000)||(num>99999))
// {
//     Console.WriteLine($"Число {num} не пятизначное.");
    
// }
// else
// {
//     int a=num%10;
//     int b=(num%100)/10;
//     int c=(num/1000)%10;
//     int d=num/10000;

//     if (a==d&&b==c)
//     {
//         Console.WriteLine($"Число {num} - полиндром.");
//     }
    
//     else
//     {
//         Console.WriteLine($"Число {num} - не полиндром.");
//     }
// }

//ЗАДАЧА2

// //Первая точка
// Console.WriteLine("Введите координату x первой точки.");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y первой точки.");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z первой точки.");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("~~~~~~~~~~~~~~~~~~");
// //Вторая точка

// Console.WriteLine("Введите координату x второй точки.");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y второй точки.");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z второй точки.");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow ((x2-x1),2)+ Math.Pow ((y2-y1),2)+Math.Pow ((z2-z1),2));
// Console.WriteLine($"Расстояние между первой и второй точкой равняется {d}");

//ЗАДАЧА3

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while (num>=count)
// {
//     Console.WriteLine(Math.Pow (count,3));
//     count=count+1;
// }