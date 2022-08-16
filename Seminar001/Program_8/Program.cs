// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число, а я выдам все чётные положительные числа меньше его: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while(counter <= number){
    int signed = counter % 2;
    if(signed == 0){
        Console.Write(counter + ", ");
    }
    counter++;
}
