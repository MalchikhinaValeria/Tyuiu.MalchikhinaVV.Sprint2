using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalchikhinaVV.Sprint2.Task2.V11.Lib;

namespace Tyuiu.MalchikhinaVV.Sprint2.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #2 | Выполнил: Мальчихина В. В. | ИИПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if: Полная и короткая форма записи                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Мальчихина Валерия Викторовна | ИИПб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите значение Х:  ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:  ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }


            Console.ReadLine();
        }
    }
}

