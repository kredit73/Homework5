

using static MyLibrary;
using static System.Console;

public class Homework5
{
    /// <summary>
    ///Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.<br/> 
    ///Напишите программу, которая покажет количество чётных чисел в массиве.<br/>
    ///[345, 897, 568, 234] -> 2
    /// </summary>
    
    static public void task34()
    {
        WriteLine("Решение 34 задачи");
        int[] ar = CreateArray(4);
        Fill(ar, 100, 999);
        WriteLine(Print(ar));
        WriteLine(countEven(ar));
    }


/// <summary>
/// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
///[3, 7, 23, 12] -> 19
///[-4, -6, 89, 6] -> 0
/// </summary>
    static public void task36()
    {
        WriteLine("Решение 36 задачи");
        int[] ar = CreateArray(4);
        Fill(ar, -9, 9);
        WriteLine(Print(ar));
        WriteLine(sumEven(ar));
    }
    
///Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

    static public void task38()
    {
        WriteLine("Решение 38 задачи");
        double[] arrayDouble = CreateArrayDouble(5);
        FillDouble(arrayDouble);
        WriteLine(PrintDouble(arrayDouble));
        WriteLine($"{ diffDoubleArray(arrayDouble):0.00}");
    }
}
