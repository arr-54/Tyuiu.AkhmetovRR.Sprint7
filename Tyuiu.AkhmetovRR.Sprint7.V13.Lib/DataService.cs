using System.IO;
using System.Text;

namespace Tyuiu.AkhmetovRR.Sprint7.V13.Lib
{
    public class DataService
    {
        public static string SelectFile(string path, string data)
        {
            if (File.Exists(path))
            {
                path = $"{data}.csv";
            }
            else
            {
                path = $"{data}.csv";
                using (StreamWriter writer = new StreamWriter(path, append: false, encoding: Encoding.UTF8))
                {
                    writer.WriteLine(string.Join(";", new string[] { "Название страны", "Столица", "Площадь территории", "Развита ли страна", "Количество населения", "Преобладающая национальность", "Примечание" }));
                }
            }
            return path;
        }
        public static long Sum(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++) 
            { 
                sum += array[i];
            }
            return sum;
        }
        public static long Srednee(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum/array.Length;
        }
        public static long Minimalnoe(long[] array)
        {
            long min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < min) min = array[i];
            }
            return min;
        }
        public static long Maxsimalnoe(long[] array)
        {
            long max = array[0];
            for (int i = 0; i > array.Length - 1; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }
    }
}
