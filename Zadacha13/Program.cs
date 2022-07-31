void Zadacha13()
{
    //Напишите программу, которая с помощью деления выводит третью цифру
    //заданного числа или сообщает, что третьей цифры нет.
    Console.Write("Введите любое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);

    if (number < 100)
    {
        Console.Write("В числе менее трех цифр");
    }
    else
    {
        while (number > 999)
        {
            number/=10;
        }
        Console.Write("Третья цифра числа: " + number%10);
    }
}

Zadacha13();