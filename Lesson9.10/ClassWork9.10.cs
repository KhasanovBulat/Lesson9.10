using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace Lesson9._10
{
    class Program
    {
        static string CountFives(int[] Array1, int[] Array2)
        {
            int count_1 = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] == 5)
                {
                    count_1 += 1;
                }
            }
            int count_2 = 0;
            for (int i = 0; i < Array2.Length; i++)
            {
                if (Array2[i] == 5)
                {
                    count_2 += 1;
                }
            }
            if (count_1 == count_2)
            {
                return "Drinks All Round! Free Beers on Bjorg!";
            }
            else
            {
                return "Ой,Бьорг - пончик! Ни для кого пива!";
            }
        }


        struct Student
        {
            public string name;
            public string surname;
            public int BirthYear;
            public string subject;
            public int scores;
        }

        static void Swap(List<string> array, int i1, int i2, string value1, string value2)
        {
            array[i1] = value2;
            array[i2] = value1;
        }


        /* static void Sort(Dictionary<int, Student> students)
         {
             SortedDictionary<int, Student> sort = new SortedDictionary<int, Student>(students);
             students.Clear();
             foreach (KeyValuePair<int, Student> keyValue in sort)
             {
                 Console.WriteLine(Convert.ToString(keyValue.Key) + " " + keyValue.Value);
                 students.Add(keyValue.Key, keyValue.Value);
             }
         }*/


        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            try
            {
                Console.WriteLine("Сколько человек в командах?");
                int participants_number = Convert.ToInt32(Console.ReadLine());

                int[] BavarianBeerBears = new int[participants_number];
                int[] ScandinavianSchöllers = new int[participants_number];
                Random rand = new Random();
                Console.WriteLine("Цифры первой команды:");
                for (int i = 0; i < BavarianBeerBears.Length; i++)
                {
                    BavarianBeerBears[i] = rand.Next(9);
                    Console.WriteLine(BavarianBeerBears[i]);
                }
                Console.WriteLine("Цифры второй команды:");
                for (int j = 0; j < ScandinavianSchöllers.Length; j++)
                {
                    ScandinavianSchöllers[j] = rand.Next(9);
                    Console.WriteLine(ScandinavianSchöllers[j]);
                }
                Console.WriteLine(CountFives(BavarianBeerBears, ScandinavianSchöllers));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Введите целое число");
            };


            Console.WriteLine("Задание 2");
            List<string> ImagesList = new List<string>()
            {
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\1.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\2.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\3.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\4.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\5.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\6.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\7.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\8.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\9.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\10.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\11.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\12.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\13.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\14.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\15.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\16.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\17.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\18.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\19.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\20.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\21.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\22.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\23.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\24.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\25.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\26.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\27.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\28.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\29.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\30.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\31.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\32.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\33.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\34.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\35.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\36.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\37.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\38.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\39.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\40.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\41.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\42.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\43.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\44.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\45.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\46.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\47.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\48.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\49.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\50.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\51.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\52.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\53.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\54.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\55.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\56.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\57.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\58.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\59.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\60.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\61.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\62.jpg",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\63.png",
               @"C:\Users\rubis\source\repos\Lesson9.10\Lesson9.10\bin\Debug\Task2\64.png",
            };
            Console.WriteLine("Изначальный лист: {0}", ImagesList);
            foreach (string item in ImagesList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 64; i++)
            {
                Random rnd = new Random();
                int random_number = rnd.Next(ImagesList.Count());
                Swap(ImagesList, i, random_number, ImagesList[i], ImagesList[random_number]);
            }
            Console.WriteLine("Полученный лист:");
            foreach (string item in ImagesList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Задание 3");
            string file = ("StudentsDictionary.txt");
            Dictionary<int, string> Students = new Dictionary<int, string>();
            foreach (string line in File.ReadLines(file))
            {
                Student student;
                student.name = line.Split()[0];
                student.surname = line.Split()[1];
                student.BirthYear = int.Parse(line.Split()[2]);
                student.subject = line.Split()[3];
                student.scores = int.Parse(line.Split()[4]);
                Students.Add(student.name + " " + student.surname, student.BirthYear + " " + student.subject + " " + student.scores);
            }
            Console.WriteLine("Введите 'Новый студент или Удалить или Сортировать':");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case ("новый студент"):
                    Console.WriteLine("Впишите данные студента в строчку через пробел в формате\n(фамилия, имя, год рождения, предмет для поступления, количество баллов):");
                    string data = Console.ReadLine();
                    Student student;
                    student.name = data.Split()[0];
                    student.surname = data.Split()[1];
                    student.BirthYear = int.Parse(data.Split()[2]);
                    student.subject = data.Split()[3];
                    student.scores = int.Parse(data.Split()[4]);
                    Students.Add(student.name + " " + student.surname, student.BirthYear + " " + student.subject + " " + student.scores);
                    File.AppendAllText(file, Environment.NewLine);
                    File.AppendAllText(file, student.name + " " + student.surname + " " + student.BirthYear + " " + student.subject + " " + student.scores);
                    Console.WriteLine("Студент добавлен в список");
                    break;






            }
        }
    }
}
