using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Create();
        }

        public void Create()
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

            foreach (var item in SF2022User05Lib.Calculations.AvailablePeriods(beginWorkingTime, endWorkingTime, 30, startTime, duration))
            {
                TextBlock textBlock = new TextBlock(); 
                textBlock.Text = item;
                Stack.Children.Add(textBlock);

            }
        }
    }
}
