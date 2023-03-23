using System;

namespace _8_лаба
{
    class Car : Transport, INext
    {
        private string data;
        private string fio;
        private string vin;
        public string FIO
        {
            set
            {
                string s = value.Replace(" ", "");
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(((s[i] >= 'а') && (s[i] <= 'я')) || ((s[i] >= 'А') && (s[i] <= 'Я'))))
                    {
                        throw new Exception("\nФамилия должна содежать только буквы кириллицы ");
                    }
                }
                fio = value;
            }
            get
            { return fio; }
        }
        public string Data
        {
            set
            {
                if (value.Trim().Length == 10)
                {
                    string s = value.Replace(".", "");
                    for (int i = 0; i < s.Length; i++)
                    {
                        if ((((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= 'A') && (s[i] <= 'Z')) || ((s[i] >= 'А') && (s[i] <= 'Я')) || ((s[i] >= 'а') && (s[i] <= 'я'))))
                        {
                            throw new Exception("\nНеверный формат(Должны быть только цифры) ");
                        }
                    }

                }
                else
                {
                    throw new Exception("Неверный формат");
                }
                data = value;
            }
            get { return data; }
        }
        public string Vin
        {
            set
            {
                if (value.Trim().Length != 17)
                {
                    throw new Exception("Неверный Vin-номер");
                }
                vin = value;
            }
            get { return vin; }
        }
        public override string Info()
        {
            return base.Info() + ($"\nФИО водителя: {FIO}\nНомер автомобиля: {Num}\nVin-номер: {Vin}\nДата поставки на учёт: {Data}");

            /* return ($"\nЛого автомобиля: {LoGo}\nМодель автомобиля: {Model}\nФИО водителя: {FIO}\nНомер автомобиля: {Num}\nVin-номер: {Vin}\nДата поставки на учёт: {Data}\nДлина машины: {Length}");*/
        }
        public string Sound()
        {
            return ("Brum-brum");
        }
        public void Replace(string f)
        {
            fio = f;
            Console.WriteLine($"Новое имя владельца: {fio}");
        }
        public string Dlina()
        {
            if (length >= 4 && length <= 7)
            {
                return ($"Автомобиль средней длины c длиной: {length}");
            }
            if (length >= 8 && length <= 12)
            {
                return ($"Автомобиль большой длины c длиной: { length}");
            }
            else
            {
                throw new Exception("Данная длина не соответсвует легковому автомобилю");
            }
        }
        public Car()
        {
            LoGo = "Mercedes";
            Model = "AMG1";
            FIO = " Павлов Константин Альбертович";
            Num = "7421";
            Vin = "a23fa2gkct214og5f";
            Data = "22.02.2002";
            Length = 4.5;

        }
        public Car(string LogoParam, string ModelParam, string FIOParam, string NumParam, string VinParam, string DataParam, double LengthParam)
        {
            LoGo = LogoParam;
            Model = ModelParam;
            FIO = FIOParam;
            Num = NumParam;
            Vin = VinParam;
            Data = DataParam;
            Length = LengthParam;

        }
    }
}
