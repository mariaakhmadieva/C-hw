﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random list = new Random();
int val = list.Next();
int val1 = list.Next();
int val2 = list.Next(); 
int val3 = list.Next();
int val4 = list.Next();
int val5 = list.Next();
int val6 = list.Next(); 
int val7 = list.Next();

List<int>numbers = new List<int>()
{
    val, val1, val2, val3, val4, val5, val6, val7
};
string result = string.Join(", ", numbers.ToArray());
Console.WriteLine($"{{{result}}}");
