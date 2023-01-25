using System;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MinutesInHour = 60;
            int queueLength;
            int timePassageOnePatient = 10;
            int numberOfWaitingHours;
            int numberOfWaitingFullMinutes;
            int numberOfWaitingMinutes;            

            Console.WriteLine("Сколько пациентов в очереди перед Вами?");
            queueLength = Int32.Parse(Console.ReadLine());
            numberOfWaitingFullMinutes = queueLength * timePassageOnePatient;
            numberOfWaitingHours = numberOfWaitingFullMinutes / MinutesInHour;
            numberOfWaitingMinutes = numberOfWaitingFullMinutes % MinutesInHour;

            Console.WriteLine($"Вам осталось ждать {numberOfWaitingHours} час(а/ов), {numberOfWaitingMinutes} минут");
        }
    }
}