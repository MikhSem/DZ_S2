
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.Обязательна проверка на ввод чисел больше/меньше 3-х знаков
/*
Console.WriteLine("Введите трёхзначное число: ");

int num = int.Parse(Console.ReadLine()!);

if (num < 100 || num > 999)
   { 
    Console.WriteLine ("Вы ввели не трёхзначное число");
    }
    else 
    {
     Console.WriteLine ($"Вторая цифра числа {(num % 100) /10}");
    } 
  */  

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Берем числа до 100000

 int number = new Random().Next(100000);

    Console.WriteLine ($"Выбрано число : {number}");

if (number < 100)
{
    Console.WriteLine ($"Третьей цифры в числе нет");
}
if (number > 99 && number < 1000)
{
    Console.WriteLine ($"Третья цифра в числе: {number % 10}");
}
if (number > 999 && number < 10000)
{
    Console.WriteLine ($"Третья цифра в числе: {(number / 10) %10}");
}
if (number > 9999 && number < 100000)
{
    Console.WriteLine ($"Третья цифра в числе: {(number / 100) % 10}");
} 

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

/*Console.WriteLine("Введите число дня недели от 1 до 7: ");

int daynum= int.Parse(Console.ReadLine()!);

if (daynum < 1 || daynum > 7)
{
    Console.WriteLine ("Вы ввели неверное число. Оно должно быть в диапазоне от 1 до 7");
}
if (daynum == 6 || daynum == 7)
{
    Console.WriteLine ("Это выходной день");
}

else 
{
    Console.WriteLine ("Это будний день");
}
*/