using System;

namespace Lesson_1  
{
    class Program // Д/З Урок 1. Стрелков Максим.
    {


       
        static void Main(string[] args)



            #region Задача №1. Анкета.(вывод на экран тремя способами)


        {
            Console.Write("Введите имя ");
            string a = Console.ReadLine();

            Console.Write("Введите Фамилию ");
            string b = Console.ReadLine();

            Console.Write("Введите возраст ");
            string c = Console.ReadLine();

            Console.Write("Введите рост ");
            string d = Console.ReadLine();

            Console.Write("Введите вес ");
            string weight = Console.ReadLine();
            int e = int.Parse(weight); //вытаскиваем числовое значение из текстовой строки

            //а) используя склеивание;
            string text = a + " " + b + " " + c + " " + d + " " + e;

            Console.WriteLine("");
            Console.WriteLine(text);
            Console.WriteLine("");

            //б) используя форматированный вывод;
            Console.WriteLine("Фамилия: {1} Имя: {0}, Возраст: {2} лет, Рост: {3} см, Вес: {4} кг ", a, b, c, d, e);
            Console.WriteLine("");
            //в) используя вывод со знаком $.
            Console.WriteLine($"{a} {b} {c} {d} {e}");
            Console.WriteLine("");


            //Сравнение веса(в условии задачи не было)

            if (e >= 60)
                Console.WriteLine($"{a} ПОРА В ЗАЛ");
            else

            if (e <= 50)
                Console.WriteLine($"{a} ПОРА ПОКУШАТЬ");
            else

                Console.WriteLine($"Уххх {a} да ты В ПРЕКРАСНОЙ ФОРМЕ");

            Console.WriteLine("");

            Console.WriteLine("Нажми ENTER, чтобы узнать свой ИМТ");

            Console.ReadLine();




            #endregion


            #region      Задача №2. Индекс массы тела

            Console.Clear();

            Console.Write("Введите свой вес в кг ");
            string inputstr1 = Console.ReadLine();
            double m = double.Parse(inputstr1);


            Console.Write("Введите свой рост в метрах ");
            string inputstr2 = Console.ReadLine();
            double h = double.Parse(inputstr2);

            double v = m / (h * h);

            Console.Write($"Ваш ИМТ {v}");

            Console.ReadLine();



            #endregion


            #region Задача №3 Написать программу, которая подсчитывает расстояние между точками.(а)

            Console.Clear();


            Console.WriteLine("Введите координаты точки 1");
            Console.Write("X: ");
            string inputX1 = Console.ReadLine();
            double x1 = double.Parse(inputX1);

            Console.Write("Y: ");
            string inputY1 = Console.ReadLine();
            double y1 = double.Parse(inputY1);

            Console.WriteLine("Введите координаты точки 2");
            Console.Write("X: ");
            string inputX2 = Console.ReadLine();
            double x2 = double.Parse(inputX2);

            Console.Write("Y: ");
            string inputY2 = Console.ReadLine();
            double y2 = double.Parse(inputY2);



            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("");
            Console.WriteLine($"Результат:             {r}");

            var res = r.ToString("F");

            // Console.WriteLine($"Округленный результат {r.ToString("F")}");

            Console.WriteLine($"Округленный результат: {res}");

            Console.ReadLine();

            #endregion


            #region  (b) В виде метода

            static double formula(double x1, double x2, double y1, double y2)
            {

                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            }


            Console.WriteLine("");
            Console.WriteLine($"Результат:" + formula(x1, x2, y1, y2));
            Console.WriteLine("");
            Console.WriteLine($"Округленный результат {formula(x1, x2, y1, y2):F}");

            Console.ReadLine();


            #endregion


            #region Задача №4. Обмена значениями двух переменных.(a)C использованием третьей переменной.

            Console.Clear();

            int x = 86;
            int y = 348;

            Console.WriteLine($"Обмен переменными: a: {x} b: {y}");
            
            int z = y;

            z = x;
            x = y;
            y = z;

            Console.WriteLine($":                  a: {x} b: {y}");

           
            Console.ReadLine();

            x = x + y; // = 23 + 112 = 135
            y = x - y; // = 135 - 112 = 23 a2
            x = x - y; // = 135 - 23 = 112 a1

            Console.WriteLine($"                   a: {x} b: {y}");

            Console.ReadLine();




            #endregion







            #region Задача №5.Вывести имя, фамилию,город проживанния по центру экрана.

            Console.Clear();

            
           

            string msg = "Стрелков Максим";
            string msg1 =    "г. Москва";

           
            static void Print(string msg, int x, int y)
            {
                // Установим позицию курсора на экране
                
                Console.SetCursorPosition(x, y);
                Console.WriteLine(msg);
                
                
            }

            

            Print(msg, Console.WindowWidth/2, Console.WindowHeight/2);
            
            Print(msg1, Console.WindowWidth/2, (Console.WindowHeight/2)+1);


            Console.ReadLine();

            #endregion

        }






    }



}
