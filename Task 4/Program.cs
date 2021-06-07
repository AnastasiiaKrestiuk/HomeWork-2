using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string shopTitle = "ООО Империя";
            int innNumber = 0023456158;
            DateTime dateTime = new DateTime(2020, 06, 07, 10, 23, 48);
            string cashierName = "Иванова Т.В.";
            int saleNumber = 2467;
            string productName = "Батон";
            int quantityOfProdact = 1;
            double price = 37.28;
            double tax = 3.73;
            string formOfPayment = "НАЛ";

            Console.WriteLine($"       {shopTitle}");
            Console.WriteLine($"ИНН {innNumber}");
            Console.WriteLine($"{dateTime}   {cashierName}");
            Console.WriteLine($"ПРОДАЖА           №{saleNumber}");
            Console.WriteLine(productName);
            Console.WriteLine($"              {quantityOfProdact} X {price} = {price}");
            Console.WriteLine($"В том числе налог {tax}");
            Console.WriteLine($"            ИТОГО:{price}");
            Console.WriteLine($"Форма оплаты: {formOfPayment}");
        }
    }
}
