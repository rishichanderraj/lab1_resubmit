using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace rishichanderraj_deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount 1 in numeric format");
            double amount1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter amount 2 in numeric format");
            double amount2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter amount 3 in numeric format");
            double amount3 = Convert.ToDouble(Console.ReadLine());
            double[] userEntries = { amount1, amount2, amount3 };
            double total = userEntries.Sum();
            double average = (total / 3);
            double min = userEntries.Min();
            double max = userEntries.Max();
            string stringTotal = Convert.ToString(total);
            Console.WriteLine("The average amount of your entries is {1}, the lowest amount is {2}, and the highest amount is {3}", total, average, min, max);
            Console.WriteLine("In US currency the total you entered was " + total.ToString("C2"));
            Console.WriteLine("In Swedish currency the total you entered was " + total.ToString("C2", new CultureInfo("da-DK")));
            Console.WriteLine("In Japanese currency (without decimals) the total you entered was " + total.ToString("C0", new CultureInfo("ja-JP")));
            Console.WriteLine("In Thai currency the total you entered was " + total.ToString("C2", new CultureInfo("th-TH")));
        }
    }
}
