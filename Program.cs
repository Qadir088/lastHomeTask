
//1.IsPrime metodu - parametr olaraq integer value qəbul edir. Göndərilmiş
//integer dəyərin sadə olub olmadığını qaytarır.Ədəd sadədirsə true, deyilsə false qayıtmalıdır
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            IsPrime(16);
            #endregion
            #region Task2;
            if (CalcAve(54, 65, 76) > 60)
                Console.WriteLine("Mezun oldunuz");
            else
            {
                Console.WriteLine("Mezun olmadiniz");
            }
            #endregion

        }
        #region Task1
        static void IsPrime(int value)
        {

            int count = 0;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        #endregion
        #region Task2
        static int CalcAve(params int[] Scores)
        {
            int sum = 0;
            for(int i = 0;i< Scores.Length; i++)
            {
                sum += Scores[i];
            }
            return sum/Scores.Length;
        }
        #endregion 


    }
}