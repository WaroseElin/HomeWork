// Задача 4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Number = 1;


while(Number <= number)
    {
 if(Number % 2 ==0)
 Console.Write(Number + ", ");
 Number ++;
    }