// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = 1;

Console.WriteLine("Все четные числа от 1 до " + numberN + ": ");
if(numberN <= 1)
  {
    Console.WriteLine("Введенное число не удовлетворяет условию задачи!");
  }

while (index <= numberN)
{
  if(index % 2 == 0)
  {
      Console.WriteLine(index);
      index++;
  }
  else
  {
    index++;
  }
}
