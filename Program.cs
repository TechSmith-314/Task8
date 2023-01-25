using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueLength;
            int timePassageOnePatient = 10;
            int numberOfWaitingHours;
            int numberOfWaitingFullMinutes;
            int numberOfWaitingMinutes;
            const int minutesInHour = 60;

            Console.WriteLine("Сколько пациентов в очереди перед Вами?");
            queueLength = Int32.Parse(Console.ReadLine());
            numberOfWaitingFullMinutes = queueLength * timePassageOnePatient;
            numberOfWaitingHours = numberOfWaitingFullMinutes / minutesInHour;
            numberOfWaitingMinutes = numberOfWaitingFullMinutes % minutesInHour;

            Console.WriteLine($"Вам осталось ждать {numberOfWaitingHours} час(а/ов), {numberOfWaitingMinutes} минут");
        }
    }
}