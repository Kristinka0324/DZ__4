using System;

namespace DZ__4__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFullName("Назарбаев", "Нурсултан", "Абишевич");
            GetFullName("Путин", "Владимир", "Владимирович");
            GetFullName("Антипова", "Кристина", "Васильевна");
        }
        static void GetFullName(string lastName, string firstName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }

    }
}
