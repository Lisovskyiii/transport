using System;


namespace _8_лаба
{
     public class Transport
    {
        private static uint massa1 = 500;
        private static uint massa2 = 2000;
        public string model;
        public string logo;
        public string num;
        public double length;
        public double massa;
        public double Massa
        {
            set
            {
                if (value < 500)
                {
                    throw new Exception("Вряд-ли у автомобиля может быть такая масса");
                }
                massa = value;
            }
            get { return massa; }
        }
        public string Model
        {
            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new Exception();
                }

                model = value;
            }
            get { return model; }
        }
        public string Num
        {
            set
            {
                if (value.Trim().Length == 4)
                {
                    int k = Int32.Parse(value);
                }
                else
                {
                    throw new Exception("Неверный формат");
                }
                num = value;
            }
            get { return num; }
        }

        public string LoGo
        {
            set
            {
                string s = value.Replace(" ", "");
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(((s[i] >= 'a') && (s[i] <= 'z')) || ((s[i] >= 'A') && (s[i] <= 'Z'))))
                    {
                        throw new Exception("\nЛого должно содежать только буквы латинцы ");
                    }
                }
                logo = value;
            }
            get { return logo; }
        }

        public double Length
        {
            set
            {
                if (value < 4 || value > 17)
                {
                    throw new Exception("Неверное значение длины автомобиля");
                }
                length = value;
            }
            get { return length; }
        }

        public static bool GetMassa(uint massa)
        {
            if (massa > massa1 & massa < massa2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public virtual string Info()
        {
            return ($"\nЛого автомобиля: {LoGo}\nМодель автомобиля: {Model}\nНомер автомобиля: {Num}\nДлина автомобиля: {Length}");
        }
        public char Function()
        {
            return Num[0];
        }
        public Transport()
        {
            LoGo = "Toyota";
            Model = "MC36";
            Num = "7400";
            Length = 12;
            Massa = 700;
        }
        public Transport(string LogoParam, string ModelParam, string NumParam, double LengthParam, double MassaParam)
        {
            LoGo = LogoParam;
            Model = ModelParam;
            Num = NumParam;
            Length = LengthParam;
            Massa = MassaParam;
        }

    }
}
