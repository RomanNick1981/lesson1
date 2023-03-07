// // // Ввод чисел

// // Console.Clear(); // очистка консоли
// // // int n = Convert.ToInt32(Console.ReadLine());
// // int n = int.Parse(Console.ReadLine()!);
// // Console.WriteLine(n * 3);
// // // cmd + / 

// // /*
// // комментирование
// // */ 

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // Интерполяция строк
// // Console.WriteLine($"Результат {a} + {b} = {a + b}");
// // Console.WriteLine("Результат " + a + " + " + b + " = " + (a + b));
// // Console.WriteLine(a > b);
// if (a > b)
//     Console.WriteLine(a);
// else if (a < b)
//     Console.WriteLine(b);
// else
//     Console.WriteLine("=");
// for(int i = 1; i <= 10; i++) // 1 2 3 4 5 6 7 8 9 10 
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 1; i <= 10; i+=2) // 1 3 5 7 9
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 10; i > 0; i--) // 10 9 8 7 6 5 4 3 2 1
//     Console.Write($"{i} ");
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * n);

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (m * m == n)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");


// Console.Clear();
// Console.Write("Введите день недели(от 1 до 7): ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите день недели(от 1 до 7): ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");
// else if (n == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");

