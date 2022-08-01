void Zadacha15()
{
   //Напишите программу, которая принимает на вход цифру, обозначающую день недели,
   //и проверяет, является ли этот день выходным.

   Console.Write("Введите число дня недели от 1 до 7: ");
   int number_week = Convert.ToInt32(Console.ReadLine());

   if (number_week > 7 || number_week <= 0)
   Console.WriteLine("Введено некорректное число недели");
   else if(number_week == 1)
   Console.WriteLine("Понедельник - будний день");
   else if(number_week == 2)
   Console.WriteLine("Вторник - будний день");
   else if(number_week == 3)
   Console.WriteLine("Среда - будний день");
   else if(number_week == 4)
   Console.WriteLine("Четверг - будний день");
   else if(number_week == 5)
   Console.WriteLine("Пятница - будний день");
   else if(number_week == 6)
   Console.WriteLine("Суббота - выходной день");
   else if(number_week == 7)
   Console.WriteLine("Воскресенье - выходной день");
}

Zadacha15();