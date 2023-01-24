using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueLength;
            int timePassageOnePatient = 10;
            int countHours;
            int countMinutes;

            Console.WriteLine("Сколько пациентов в очереди перед Вами?");
            queueLength = Int32.Parse(Console.ReadLine());
            countMinutes = queueLength * timePassageOnePatient;
            countHours = countMinutes / 60;
            countMinutes = countMinutes - (countHours * 60);

            Console.WriteLine($"Вам осталось ждать {countHours} час(а/ов), {countMinutes} минут");
        }
    }
}
