Console.WriteLine("Введите два числа через Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int min = Math.Min(firstNumber, secondNumber);
if(min*min == firstNumber){
    Console.WriteLine($"{firstNumber} является квадратом числа, {secondNumber}");
}else if(min*min == secondNumber){
    Console.WriteLine($"{secondNumber} является квадратом числа, {firstNumber}");
}else{
    Console.WriteLine("Ниодно число не является квадартом второго");
}
