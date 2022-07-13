//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("введите число не менее трехзначного");
int num = Convert.ToInt32(Console.ReadLine());
if  (num >=100 && num <1000)
{int secondDigit = (num/10) % 10;
Console.WriteLine($"Второе число = {secondDigit} ");}
else
{
    Console.WriteLine("Число не трехзначное");
}
