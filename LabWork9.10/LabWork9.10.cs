using System;
using System.IO;


namespace LabWork9._10
{
    class Program
    {
        static void CountVowelsAndConsonants(char[] TextSymbols, out int VowelsNumber, out int ConsonantsNumber)
        {
            VowelsNumber = 0;
            ConsonantsNumber = 0;
            char[] Vowels = { 'а', 'о', 'э', 'е', 'и', 'ы', 'у', 'ё', 'ю', 'я' };
            char[] Consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            foreach (char a in TextSymbols)
            {
                foreach (char v in Vowels)
                {
                    if (a == v) VowelsNumber++;
                }
                foreach (char c in Consonants)
                {
                    if (a == c) ConsonantsNumber++;
                }
            }
        }
        
        static void PrintTheMatrix(int[,] matrix) //метод для печати матрицы
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
                Console.WriteLine();
            } 
        }

        static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) 
        {
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                int[,]matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
                for(int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix3.GetLength(1); j++)
                    {
                        matrix3[i, j] = 0;
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
                    }
                    
                }
                return matrix3;
            }
            int[,] e = null;
            return e;
        }

        static double[] Average (int[,] T)
        {
            double[] average = new double[T.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    sum += T[i, j];
                }
                average[i] = sum / T.GetLength(1);
            }
            return average;
        }

        static double[] BubbleSort(double[] Array)
        {
            double temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 6.1");
            StreamReader reader = new StreamReader("MyFile.txt");
            string input = reader.ReadToEnd();
            char[] inputData = input.ToCharArray();
            CountVowelsAndConsonants(inputData, out int Vowels, out int Consonants);
            Console.WriteLine("Количество гласных: {0} Количество согласных: {1}", Vowels, Consonants);
            reader.Close();

            Console.WriteLine("Task 6.2");
            int[,] Matrix1 = { { 5, 9 }, { 4, 3 } };
            int[,] Matrix2 = { { 12, 6 }, { 8, 0 } };
            PrintTheMatrix(Matrix1);
            PrintTheMatrix(Matrix2);
            int[,] Matrix3 = MatrixMultiplication(Matrix1, Matrix2);
            if(Matrix3 != null)
            {
                PrintTheMatrix(Matrix3);
            }

            Console.WriteLine("Task 6.3");
            Random rnd = new Random();
            int[,] Temperature = new int[12, 30];
            for (int i = 0; i < 12; i++)  
            {
                Console.WriteLine("Месяц " + i);
                for (int j = 0; j < 30; j++)
                {
                    Temperature[i, j] = rnd.Next(-30, 30);
                    Console.Write(Temperature[i, j] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Средняя температура:");
            double[] result = Average(Temperature);
            for (int i = 0; i < 12; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();

            BubbleSort(result);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < 12; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();

            Console.WriteLine("homemet4");
            string vowels = "аеёиоуыэюя";
            string consonants = "бвгджзйклмнпрстфхцчшщ";
            string str = File.ReadAllText("Text.txt");
            var list = new List<char>();
            char[] symbols = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                symbols[i] = str[i];
            }
            Console.WriteLine(str);
            int countVowels = 0;
            int countConsonants = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(list[i]))
                {
                    countVowels++;
                }
                else if (consonants.Contains(list[i]))
                {
                    countConsonants++;
                }
            }
            Console.WriteLine("Кол-во гласных в файле = " + countVowels);
            Console.WriteLine("Кол-во согласных в файле = " + countConsonants);
        }
        
        



    }

    
}
