//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;
Console.WriteLine("вводим первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вводим второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вводим третье число");
int threeNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    max = (firstNumber);
}
else
{
    max = (secondNumber);
}

if (max > threeNumber)
{
    max = (max);
}
else
{
    max = (threeNumber);
}

Console.WriteLine($"max =  {max}");