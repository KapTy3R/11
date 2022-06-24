using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestingSF2022User05Lib
    {
        [TestMethod] //Слишком много промежутков
        public void MuchDurationCount()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход

        }

        [TestMethod] //Слишком много отдыха
        public void MuchStartTimeCount()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(14, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(14, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(15, 00, 0);
            startTimeList.Add(startTime5);

            TimeSpan startTime6 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime6);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход

        }

        [TestMethod] //Отрицательно время консультанции
        public void ConsultationTimeMinus()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40}; //задаём времена отдыхов

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, -30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Конец рабочего дня раньше, чем начало
        public void BeginHigherEnd()
        {
            TimeSpan endWorkingTime = new TimeSpan(8, 0, 0); //конец работы
            TimeSpan beginWorkingTime = new TimeSpan(18, 0, 0); //начало работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Отрицательное начало рабочего дня
        public void MinusBeginTime()
        {
            TimeSpan beginWorkingTime = new TimeSpan(-8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Отрицательное конец рабочего дня
        public void MinusEndTime()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(-18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Отрицателное начало и конец рабочего дня
        public void MinusEndAndBeginTime()
        {
            TimeSpan beginWorkingTime = new TimeSpan(-8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(-18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов (тут на один больше)

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Начало рабочего дня равно нулю
        public void NullBeginTime()
        {
            TimeSpan beginWorkingTime = new TimeSpan(0, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов 

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Конец рабочего дня равно нулю
        public void NullEndTime()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(0, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40, 50 }; //задаём времена отдыхов 

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }

        [TestMethod] //Время консультанции нуль
        public void TimeConsultMinus()
        {
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0); //начало работы
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0); //конец работы

            List<TimeSpan> startTimeList = new List<TimeSpan>(); //отдыхи

            TimeSpan startTime1 = new TimeSpan(10, 0, 0); //задаем время отдыха
            startTimeList.Add(startTime1); //добавляем отдых в лист

            TimeSpan startTime2 = new TimeSpan(11, 0, 0);
            startTimeList.Add(startTime2);

            TimeSpan startTime3 = new TimeSpan(15, 0, 0);
            startTimeList.Add(startTime3);

            TimeSpan startTime4 = new TimeSpan(15, 30, 0);
            startTimeList.Add(startTime4);

            TimeSpan startTime5 = new TimeSpan(16, 50, 0);
            startTimeList.Add(startTime5);

            TimeSpan[] startTime = startTimeList.ToArray(); //преобразуем в массив


            int[] duration = { 60, 30, 10, 10, 40 }; //задаём времена отдыхов

            string[] actual = SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 0, startTime, duration);
            string[] Expected = { "-1" };
            Assert.AreEqual(Expected[0], actual[0]); //Проверяем на выход
        }
    }
}
