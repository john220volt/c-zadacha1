// задача 1. 
Console.WriteLine("Задача 1");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Наибольшее число: " + numberA);
    Console.WriteLine("Наименьшее число: " + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine("Наибольшее число: " + numberB);
    Console.WriteLine("Наименьшее число: " + numberA);
}
else Console.WriteLine("Числа равны");

//задача 2
// Console.WriteLine("Задача 2");
// Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

// Console.WriteLine("Введите первое число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberD = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int numberE = Convert.ToInt32(Console.ReadLine());

// if 


//задача 3
Console.WriteLine("Задача 3");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");

Console.WriteLine("Введите число: ");
int numberF = Convert.ToInt32(Console.ReadLine());

if (numberF %2 == 0)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");


//задача 4
Console.WriteLine("Задача 4");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число: ");
int numberG = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат: ");

for (int i = 2; i <= numberG; i = i +2)
{
 Console.Write(i+" ");   
}
Console.WriteLine();