using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NazarovSV.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int x)
        {
            string res;
            switch (x)
            {
                case 6:
                    res = "Шестёрка";
                    break;
                case 7:
                    res = "Семёрка";
                    break;
                case 8:
                    res = "Восьмёрка";
                    break;
                case 9:
                    res = "Девятка";
                    break;
                case 10:
                    res = "Десятка";
                    break;
                case 11:
                    res = "Валет";
                    break;
                case 12:
                    res = "Дама";
                    break;
                case 13:
                    res = "Король";
                    break;
                case 14:
                    res = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Номер карты должен быть от 6 до 14 включительно. Значаение {x}");
            }
            return res;
        }
    }
}
