using System;

namespace StringNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа через пробел:\n");
            string Num = Console.ReadLine();
            string[] NumCh = Num.Split(new char[] { ' ' });//разделение строки по символам разделитель пробел
            int SunNum = 0;
            Console.WriteLine("\nРезультат суммы введеных чисел:\n");
            for (int i = 0; i < NumCh.GetLength(0); i++)
            {

                SunNum = SunNum + Convert.ToInt32(NumCh[i]);
                
                //SStr = SStr.Insert(i,N);
                if (i < NumCh.GetLength(0) - 1)
                {
                    Console.Write($"{NumCh[i]}+");
                }
                else
                {
                    Console.Write($"{NumCh[i]}={SunNum}");
                }
                

            }
            Console.ReadKey();
        }
        
        

    }
}

