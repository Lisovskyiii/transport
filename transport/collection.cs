
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_лаба
{
    public class Transports
    {
        public Transports()
        { }
        public ArrayList ListOfTransports
        {
            get;
            private set;
        }

        public bool ContainTwo(string model, string num)
        {
            foreach (Transport transport in ListOfTransports)
            {
                if (transport.Model == model && transport.Num == num)
                {
                    if (SaveToo("file.txt", transport) == true)
                        Console.WriteLine("File is saved");
                    else
                        Console.WriteLine("Error");
                    return true;
                }
            }
            return false;
        }
        public ushort Min()
        {
            var list = new List<double>();
            foreach (Transport transport in ListOfTransports)
            {
                list.Add(transport.Massa);
            }
            return (ushort)list.Min();
        }
        public short Average()
        {
            var list = new List<double>();
            foreach (Transport transport in ListOfTransports)
            {
                list.Add(transport.Length);
            }
            return (short)list.Average(x => x);
        }
        public bool Save(string filename)
        {
            FileStream f = new(filename, FileMode.OpenOrCreate);
            StreamWriter writer = new(f, Encoding.Default);
            foreach (Transport transport in ListOfTransports) 
            {
                writer.WriteLine(transport.ToString());
            }
            writer.Flush();
            f.Close();
            return true;
        }
        public static bool SaveToo(string filename, Transport transport)
        {
            FileStream f = new(filename, FileMode.Append);
            StreamWriter writer = new(f, Encoding.Default);
            writer.WriteLine(transport.ToString());
            writer.Flush();
            f.Close();
            return true;
        }
        public static void Read(string filename)
        {
            FileStream f = new(filename, FileMode.Open);
            StreamReader reader = new(f, Encoding.Default);
            string line;
            while (!reader.EndOfStream)
            {
                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                    Console.WriteLine();
                } while (line != null);
            }
            reader.Close();
            f.Close();
        }
        public Transports(ArrayList ListOfTransports)
        {
            this.ListOfTransports = ListOfTransports;
        }
        public void Menu(Transports transports)
        {
            Output();
            byte num = Convert.ToByte(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Введите имя файла");
                    string file = Console.ReadLine();
                    if (transports.Save($"{file}.txt") == true)
                        Console.WriteLine("File is saved");
                    else
                        Console.WriteLine("Error");
                    Menu(transports);
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Введите имя файла");
                        string filename = Console.ReadLine();
                        Read($"{filename}.txt");
                    }
                    catch (Exception)
                    { Console.WriteLine("Error"); }
                    Menu(transports);
                    break;
                case 3:
                    Console.WriteLine("Введите модель транспорта и номер транспорта");
                    string a = Console.ReadLine();
                    string b =Console.ReadLine();
                    if (transports.ContainTwo(a, b))
                    {
                        Console.WriteLine("Такой объект имеется");
                    }
                    else
                        Console.WriteLine("Таких объектов нету");
                    Menu(transports);
                    break;
                case 4:
                    Console.WriteLine(Min());
                    Menu(transports);
                    break;
                case 5:
                    Console.WriteLine(Average());
                    Menu(transports);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("wrong enter");
                    Menu(transports);
                    break;
            }
        }
        static void Output()
        {
            Console.WriteLine("\nМеню:\n" +
                            "1 - Сохранить в файл информацию об объектах;\n" +
                            "2 - Вывести информацию из файла о всех объектах;\n" +
                            "3 - Поиск по модели и номеру транспорта;\n" +
                            "4 - Найти минимальное значение массы автомобиля у объектов;\n" +
                            "5 - Найти среднее значение массы у всего транспорта;\n" +
                            "0 - выйти.");
        }
    }
}