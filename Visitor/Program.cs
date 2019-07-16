using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            SomeProduct someProduct = new SomeProduct(213);

            Console.WriteLine(someProduct);

            Console.WriteLine($"Price after tax = {someProduct.Accept(endOfYearVisitor)}");

            Console.WriteLine($"Price after gift = {someProduct.Accept(new GiftVisitor())}");

            Console.WriteLine($"Price after gift = {vodka.Accept(new GiftVisitor())}");

            Console.WriteLine("*******************************************");

            Shop shop = new Shop(1000);

            Console.WriteLine(shop);

            Console.WriteLine($"Price after gift = {shop.Accept(new GiftVisitor())}");

            Console.WriteLine($"Price after tax = {shop.Accept(endOfYearVisitor)}");
        }
    }
}
