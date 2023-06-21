/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

*/



Console.WriteLine("input number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number2");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 0; i < num2; i++)
{
    result = result * num1;
}
    

if (num2 > 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("must be > 0");
}
