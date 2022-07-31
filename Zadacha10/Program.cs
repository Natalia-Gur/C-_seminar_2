void Zadacha10()
{
    //Напишите программу, которая принимает на вход трёхзначное число
    // и на выходе показывает вторую цифру этого числа.

    Random rand = new Random();
    int number = rand.Next(100,1000);
    Console.WriteLine(number);

    int tens = number/10%10;
    Console.WriteLine("Вторая цифра числа: " + tens);
}

Zadacha10();