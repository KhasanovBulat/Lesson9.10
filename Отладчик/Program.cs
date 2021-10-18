using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отладчик
{
    class Program
    {
        static List<int> Shuffle(List<int> oldList)
        {
            Random rnd = new Random();
            int count = 1;
            List<int> newList = new List<int>();
            while (count <= 64)
            {
                newList.Add(oldList[rnd.Next(0, 64)]);
                count += 1;
            }
            return newList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2)\n");

            List<int> images = new List<int>();
            for (int i = 1; i <= 64; i++)
            {
                if (i % 32 != 0)
                {
                    images.Add(i % 32);
                }
                else
                {
                    images.Add(32);
                }
            }

            string str1 = "";
            foreach (int i in images)
            {
                str1 += "[" + i.ToString() + "] ";
            }
            Console.WriteLine(str1 + "\nТак выглядит список до тасовки");

            string str2 = "";
            foreach (int i in Shuffle(images))
            {
                str2 += "[" + i.ToString() + "] ";
            }
            Console.WriteLine(str2 + "\nТак выглядит список после тасовки\n");

            Console.ReadKey();
        }
    }
}
