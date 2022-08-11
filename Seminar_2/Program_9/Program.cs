//Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает максимальную  из двух цифр
// 78 -> 8
// 12 -> 2
// 85 -> 8
int number = new Random().Next(10, 100);
Console.WriteLine(number);
if((number/10) < (number%10)){
    Console.WriteLine("Max digit = " + number%10);
}else if((number/10) > (number%10)){
    Console.WriteLine("Max digit = " + number/10);
}else{
    Console.WriteLine("Both digit are equal = " + number%10);
}