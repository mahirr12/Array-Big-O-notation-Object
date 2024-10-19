using System.Diagnostics;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            //int[] nums = { 1, 2, 6, 4, 5, };
            //int max = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i] > max) max= nums[i];
            //}
            //Console.WriteLine(max);
            #endregion

            #region task2

            var product1 = new { Id = 1, Name = "Alma", Price = 2, Stockcount = 250 };
            var product2 = new { Id = 2, Name = "Armud", Price = 3, Stockcount = 120 };
            var product3 = new { Id = 3, Name = "Nar", Price = 5, Stockcount = 50 };
            var product4 = new { Id = 4, Name = "Qoz", Price = 10, Stockcount = 35 };
            var product5 = new { Id = 5, Name = "Fındıq", Price = 12, Stockcount = 42 };

            var products = new[] { product1, product2, product3, product4, product5 };
            
            int sum = 0;
            int count = 0;
            foreach (var product in products)
            {
                if(product.Id % 2 == 1)
                {
                    sum += product.Price;
                    count++;
                }
            }
            double avg= (double) sum / count;
            Console.WriteLine(avg.ToString("0.00"));

            #endregion
        }
    }
}
