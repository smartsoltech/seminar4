nt Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void Square(int number)
{
    int index = 1;
    while (index <= number)
    {
        System.Console.WriteLine($"Квадрат числа {index} это {index * index}");
        index++;
    }
}
int number = Prompt("Введите число:");
Square(number);