﻿// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.WriteLine("Введите два числа через Enter, так чтобы второе было кратно первому:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber%secondNumber == 0){
    Console.WriteLine("Кратно! Молодец!");
}else{
    Console.WriteLine($"Некратно, остаток: {firstNumber%secondNumber}");
}