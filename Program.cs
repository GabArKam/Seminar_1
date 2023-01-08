// Console.WriteLine("Введите целое число"); // приглашаем пользователя ввести данные
// int x = Convert.ToInt32(Console.ReadLine()); // перевели данные от пользователя в целоечисленный тип и спрятали переменную x
// int y = x*x; // формула квадрата
// Console.WriteLine("Квадрат введенного числа равен "+y); // вывод квадрата на экран

// // сделаем проверку на двузначность числа
// if(x>9 && x<100) // если x>9 и <100, то делаем следующее:
// {
//     Console.WriteLine("Вы ввели положительное двузначное число");
// }



// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// if(x / y == y) // или x == y*y
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго");
// }



Console.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
if(x == 1) Console.WriteLine("Понедельник");
else if(x == 2) Console.WriteLine("Вторник");
else if(x == 3) Console.WriteLine("Среда");
else if(x == 4) Console.WriteLine("Четверг");
else if(x == 5) Console.WriteLine("Пятница");
else if(x == 6) Console.WriteLine("Суббота");
else if(x == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine ("Введен некоретный номер дня недели");