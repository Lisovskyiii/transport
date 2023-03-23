using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_лаба
{
    class Bus : Transport, IComparable, INext
    {
        private double cost;
        private double km;
        public uint passenger;
        public uint Passenger
        {
            set
            {
                if (value < 8)
                {
                    throw new Exception("Слишком мало мест для автобуса");
                }
                passenger = value;
                if (value > 200)
                {
                    throw new Exception("Слишком много мест для автобуса");
                }
            }
            get { return passenger; }
        }
        public double Km
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Неверное значение расстояния");
                }
                km = value;
            }
            get { return km; }
        }
        public double Cost
        {
            set
            {
                if (value == 0)
                {
                    throw new Exception("Цена за км не может быть равна нулю");
                }
                cost = value;
            }
            get { return cost; }
        }
        public string Sound()
        {
            return ("Bip-bip");
        }
        public void Replace(string f)
        {
            num = f;
            Console.WriteLine($"Новый номер автобуса: {num}");
        }
        public int CompareTo(object obj)
        {
            return passenger.CompareTo(obj);
        }
        public double Proezd()
        {
            return km * cost;
        }
        public override string ToString()
        {
            return base.Info() + ($"\nЦена за км проезда: {Cost}\nРасстояние маршрута: {Km}\nКол-во пассажиров: {Passenger}\nДлина автобуса: {Length}");
        }
        public Bus()
        {
            LoGo = "Toyota";
            Model = "MC36";
            Num = "7400";
            Cost = 0.1;
            Km = 100;
            Passenger = 120;
            Length = 13;
        }
        public Bus(string LogoParam, string ModelParam, string NumParam, double CostParam, double KmParam, uint PassengerParam, ulong LengthParam)
        {
            LoGo = LogoParam;
            Model = ModelParam;
            Num = NumParam;
            Cost = CostParam;
            Km = KmParam;
            Passenger = PassengerParam;
            Length = LengthParam;
        }
        public static bool operator true(Bus k)
        {
            return k.length >= 12 && k.passenger >= 100;
        }

        public static bool operator false(Bus k)
        {

            return k.length <= 12 & k.passenger <= 100;
        }
        public static bool operator <(Bus k, Bus n)
        {
            bool status = false;

            if (k.length < n.length && k.passenger < n.passenger)
            {

                status = true;
            }
            return status;
        }
        public static bool operator >(Bus k, Bus n)
        {
            bool status = false;

            if (k.length > n.length && k.passenger > n.passenger)
            {

                status = true;
            }
            return status;
        }
        public static Bus operator ++(Bus k)
        {
            k.length++;
            k.passenger = k.passenger + 15;
            return k;
        }
        public static Bus operator --(Bus k)
        {
            k.length--;
            k.passenger = k.passenger - 15;
            return k;
        }
    }
}

