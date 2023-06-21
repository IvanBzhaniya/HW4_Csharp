/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16



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


Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.





Console.WriteLine("input number");
int num = Convert.ToInt32(Console.ReadLine());
int temp1 = num%10;
int temp2 = num%100/10;
int temp3 = num/100;
int sum = temp1+temp2+temp3;
Console.WriteLine(sum);




Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


*/

int [] CreateNewArray (int size_array)
{
    int [] random1array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        random1array[i] = new Random().Next(0, 100);
    }
    return random1array;
}

void PrintArray (int [] array_to_print)
{
    Console.WriteLine("your array is ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + " ");
}
int size = 8;
int [] firstArray = CreateNewArray(size);
PrintArray(firstArray);

