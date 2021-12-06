using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class StockManagment
    {
        public void AddStock()
        {
            int Total_Price = 0;
            int Total_Share = 0;
            Console.Write("Enter Number Of Stock: ");
            int Stock = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<Stock;i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("******** Enter Details of Stock ********");
                Console.ResetColor();
                Console.WriteLine("Enter Share Name:");
                string Sharename = Console.ReadLine();
                Console.WriteLine("Enter Number of Share :");
                int Sharenumber =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Share Price:");
                int Shareprice= Convert.ToInt32(Console.ReadLine());

                int stockPrice = Sharenumber * Shareprice; //Calculating stock 
                Console.WriteLine("The Price for stock is :  " + stockPrice);
                Total_Price += (Sharenumber * Shareprice);
                Console.WriteLine("the total price of the stock is  " + Total_Price);
            }
        }
    }
}
