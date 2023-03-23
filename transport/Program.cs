using System;
using System.Collections;

namespace _8_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Transport transport1 = new Transport();
                Transport transport2 = new Transport("Mercedes", "AMG4", "5276", 7, 1000);

                Console.WriteLine("\n[Первый транспорт]:");
                Console.Write("Информация о 1 транспорте" + transport1.Info());
                Console.WriteLine($"Автомобиль является легковым: {Transport.GetMassa(900)}");
                Console.WriteLine($"Первая цифра номера: {transport1.Function()}");

                Console.WriteLine("\n[Второй транспорт]: ");
                Console.Write("Информация о 2 транспорте" + transport1.Info());
                Console.WriteLine($"Автомобиль является легковым: {Transport.GetMassa(1500)}");
                Console.WriteLine($"Первая цифра номера: {transport2.Function()}");


                Car car1 = new Car();
                Car car2 = new Car("Honda", "Pilot", "Волков Андрей Петрович", "8999", "vavgh123lom984hkl", "14.03.2009", 5);

                Console.WriteLine("\n[Первая машина]: ");
                Console.Write($"[Информация о 1 автомобиле]: {car1.Info()}");
                Console.WriteLine("\n" + car1.Dlina());
                Console.WriteLine("Звук  автомобиля: " + car1.Sound());
                car1.Replace("Пинятин Михаил Валерьевич");
                Console.Write($"[Обновленная информация о 1 автомобиле]: {car1.Info()}");

                Console.WriteLine("\n\n[Вторая машина]: ");
                Console.Write($"[Информация о 2 автомобиле]: {car2.Info()}");
                Console.WriteLine("\n" + car2.Dlina());
                Console.WriteLine("Звук 2 автомобиля: " + car2.Sound());
                car1.Replace("Миронов Андрей Юрьевич");
                Console.Write($"[Обновленная информация о 2 автомобиле]: {car2.Info()}");


                Bus bus1 = new Bus();
                Bus bus2 = new Bus("Mazda", "Markul", "0002", 15, 400, 65, 7);

                Console.WriteLine("\n\n[Первый автобус]:");
                Console.Write("[Информация о 1 автобусе]: " + bus1.ToString());
                Console.WriteLine($"\nCтоимость проезда: {bus1.Proezd()} бел.руб");
                Console.WriteLine("Звук автобуса: " + bus1.Sound());
                bus1.Replace("0009");
                Console.Write("[Обновленная информация]" + bus1.ToString());
                if (bus1)
                    Console.WriteLine("\nАвтобус может перевозить большое кол-во людей и является крупным ");
                else
                    Console.WriteLine("Автобус не может перевозить очень много людей и не является большим");
                if (bus1 > bus2)
                    Console.WriteLine("Параметры 1 автобуса больше параметов 2");
                else
                    Console.WriteLine("Параметры 1 автобуса меньше параметов 2");
                bus1--;
                Console.WriteLine($"Обновленная длина {transport1.length}, обновленное кол-во мест {bus1.passenger}");


                Console.WriteLine("\n\n[Второй автобус]:");
                Console.Write("[Информация о 2 автобусе]: " + bus2.ToString());
                Console.WriteLine($"\nCтоимость проезда: {bus2.Proezd()} бел.руб");
                Console.WriteLine("Звук автобуса" + bus2.Sound());
                bus2.Replace("0123");
                Console.Write("[Обновленная информация 2 автобуса]: " + bus2.ToString());
                if (bus2)
                    Console.WriteLine("\nАвтобус может перевозить большое кол-во людей и является крупным ");
                else
                    Console.WriteLine("Автобус не может перевозить очень много людей и не является большим");
                if (bus1 < bus2)
                    Console.WriteLine("Параметры 2 автобуса больше параметов 1");
                else
                    Console.WriteLine("Параметры 2 автобуса меньше параметов 1");
                bus2++;
                Console.WriteLine($"Обновленная длина {bus2.length}, обновленная кол-во мест {bus2.passenger}");

                Console.WriteLine($"[Применен метод CompareTo]. Результат: {bus1.CompareTo(bus2.passenger)}, так как {bus1.passenger}>{bus2.passenger}");

                ArrayList ListOfTransports = new();
                Transports transports = new (ListOfTransports);

                transports.ListOfTransports.Add(transport1);
                transports.ListOfTransports.Add(transport2);
                transports.ListOfTransports.Add(car1);
                transports.ListOfTransports.Add(car2);
                transports.ListOfTransports.Add(bus1);
                transports.ListOfTransports.Add(bus2);
                Console.WriteLine();

                transports.Menu(transports);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

