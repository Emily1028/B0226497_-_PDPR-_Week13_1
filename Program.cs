using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week13_1");
            string[] Name = new string[]
            {
                "段昱如_1", "段昱如_2", "段昱如_3", "段昱如_4", "段昱如_5"
            };
            string[] NO = new string[]
            {
                "B0226497_1", "B0226497_2", "B0226497_3", "B0226497_4", "B0226497_5"
            };

            int[] Price = new int[]
            {
                1000,2000,3000,4000,5000
            };
            int[] Amount = new int[]
            {
                10,20,30,40,50
            };
            int[] total = new int[]{10000,40000,90000,160000,250000};
            int i;
            for (i = 0; i <= Name.GetUpperBound(0); i++)
            {
                Console.WriteLine($"產品:{i+1}\t編號:{NO[i]}\t品名:{Name[i]}\t單價:{Price[i]:#,#}\t數量:{Amount[i]:#,#}\t總價:{Price[i]* Amount[i]}");
            };
            int sum=0;
            for (i = 0; i < total.Length; i++)
                sum += total[i];
            Console.WriteLine("總價值:" + sum);

                Console.ReadLine();

        }
    }
}
