//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
Console.Write("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB)
{
    Console.WriteLine("Число А " + numberA + " равно числу В " + numberB + "!");
}
else if(numberA > numberB)
{
    Console.Write("Число A = " + numberA + " больше числа B = " + numberB + "!"); 
}
else
{
   Console.Write("Число B = " + numberB + " больше числа A = " + numberA + "!"); 
}