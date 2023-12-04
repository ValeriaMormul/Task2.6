using System;
class Program
{
    static void Main()
    {
        Console.Write("Вкажіть вік: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 12 && age <= 18)
        {
            Console.WriteLine("Вказаний вік є підлітковим");
        }
        else
        {
            Console.WriteLine("Вказаний вік не є підлітковим");
        }
    }
}