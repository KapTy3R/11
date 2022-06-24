using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User05Lib
{
    public class Calculations
    {
        public static string[] AvailablePeriods(TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime, TimeSpan[] startTimes, int[] durations)
        {
            TimeSpan Zero = new TimeSpan(0, 0, 0);

            if (durations.Count() != startTimes.Count() || consultationTime <= 0 || beginWorkingTime < endWorkingTime || beginWorkingTime > Zero || endWorkingTime > Zero)  //Проверка на совпадение отдыхов и их промежутков.
            { //Чтобы консультация не была меньше или равны нулю.
                string[] error = { "-1" };
                return error;
            }
            else
            {
                foreach (var elem in durations) //Проверяем длительности отдыха
                {
                    if (elem <= 0) //Чтобы они не были меньше или равны нулю
                    {
                        string[] error = { "-1" };
                        return error;
                    }
                } 
                TimeSpan MinutesConsultationTime = new TimeSpan(0, consultationTime, 0); //Хранит в себе промежуток
                List<string> ListString = new List<string>(); //Будет хранить в себе строки
                while (beginWorkingTime < endWorkingTime) //Пока не достигнут конец рабочего времени
                {
                    TimeSpan oldBeginWorkingTime = beginWorkingTime; //Засекаем старое время

                    int countElements = startTimes.Count(); //Считаем количество отдыхов
                    for (int i = 0; i < countElements; i++) //Проходим по элементам отдыхов
                    {
                        if (oldBeginWorkingTime.Equals(startTimes[i])) //Если старое время равно времени начала отдыха
                            MinutesConsultationTime = new TimeSpan(0, durations[i], 0); //Меняем промежуток на длительность
                    }
                    beginWorkingTime += MinutesConsultationTime; //Новое время, с учетом промежутка
                    string DurationString = $"{oldBeginWorkingTime.Hours}:{oldBeginWorkingTime.Minutes}-{beginWorkingTime.Hours}:{beginWorkingTime.Minutes}"; //Записываем в строку

                        if (!oldBeginWorkingTime.Equals(endWorkingTime) || beginWorkingTime < endWorkingTime) //Проверяем не равен ли отдых концу рабочего дня
                        ListString.Add(DurationString); //Добавляем строку
                }
                string[] result = ListString.ToArray(); //Записываем лист в массив
                return result;
            }
        }
    }
}
