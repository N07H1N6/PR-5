//********************************************************
//*Практическая работа №5                                *
//* Выполнил:Кондаков.П.А,Группа 2ИСП                    *
//*Задание:составить программу работы алгоритма ветвления*
//********************************************************
using System;

namespace PR_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int x1,x2,y1,y2,AO,BO,x=0,y=0;// объявление переменных
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Практическая работа №5");
            Console.Write("Введите координаты двух точек: \n");
            Console.Write("x1= ");//Ввод данных
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2= ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            y2 = Convert.ToInt32(Console.ReadLine());


            AO = (int)Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));//расчет длины отрезка
            BO = (int)Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
            Console.WriteLine("Длина отрезка AO:");
            Console.WriteLine(AO);
            Console.WriteLine("Длина отрезка BO:");
            Console.WriteLine(BO);
            //Проверка условия
            if (AO < BO)//если AO < BO,то
            {
                Console.WriteLine("Точка B находиться ближе к началу координат");
            }
            else if (AO > BO)//иначе
                 {
                     Console.WriteLine("Точка A находиться ближе к началу координат");
                 }
                 else Console.WriteLine("Точки находятся равноудаленно");

            Console.ReadKey();
        }

    }
}
