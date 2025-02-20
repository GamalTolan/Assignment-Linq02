using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_Linq02.ListGenerators;
using static Assignment_Linq02.Customer;
using System.Diagnostics;



namespace Assignment_Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01

            //01

            //var result = ProductList.First(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);

            //02

            //var result = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
            //Console.WriteLine(result);

            //03

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            //var result = Arr.Where(x => x > 5).ElementAt(1);
            //Console.WriteLine(result);

            #endregion




            #region part02

            //01

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.Count(number => number % 2 != 0);
            //Console.WriteLine(result);

            //02


            //var result = CustomerList.Select(customer => new {Name = customer.CustomerName ,OrdersCount = customer.Orders.Count(order => order != null) }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //03

            //var result= ProductList.Select(product => new { Name = product.ProductName, productsCount= product.Category.Count()}).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}   

            //04

            //int[] arr = {5,4,1,3,9,8, 6, 7, 2, 0 };

            //var total = arr.Sum();
            //Console.WriteLine(total);

            //05

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(word => word.Length);
            //Console.WriteLine(result);

            //06

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Min(word => word.Length);
            //Console.WriteLine(result);

            //07

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Max(word => word.Length);
            //Console.WriteLine(result);

            //08

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Average(word => word.Length);
            //Console.WriteLine(result);

            //09

            //var result = ProductList.Select(product => new { Category = product.Category, productsCount = product.Category.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}   

            //10

            //var result = ProductList.Select(product => new { Category = product.Category, product = product.ProductName, Price = new List<decimal> { product.UnitPrice }.Min() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //11??

            //12??

            //13

            //var result = ProductList.Select(product => new { Category = product.Category, product = product.ProductName, Price = new List<decimal> { product.UnitPrice }.Max() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //14??


            #endregion

            #region part03

            //01

            //var result = ProductList.Select(product => product.Category).Distinct();
            //Console.WriteLine(string.Join(",", result));

            //02

            //var result = ProductList.Select(product => product.ProductName[0])
            //                        .Union(CustomerList.Select(customer => customer.CustomerName[0]));
            //Console.WriteLine(string.Join(",", result));

            //03

            //var result = ProductList.Select(product => product.ProductName[0])
            //                        .Intersect(CustomerList.Select(customer => customer.CustomerName[0]));
            //Console.WriteLine(string.Join(",", result));

            //04

            //var result = ProductList.Select(product => product.ProductName[0])
            //                        .Except(CustomerList.Select(customer => customer.CustomerName[0]));
            //Console.WriteLine(string.Join(",", result));

            //05

            //var result= ProductList.Select(product => product.ProductName.Length >= 3? product.ProductName.Substring(product.ProductName.Length - 3): product.ProductName)
            //                       .Concat(CustomerList.Select(customer => customer.CustomerName.Length >= 3 ? customer.CustomerName.Substring(customer.CustomerName.Length - 3): customer.CustomerName));

            // Console.WriteLine(string.Join(",", result));

            #endregion

            #region part04
            //01

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);

            //02
            //var result = ProductList.Select(product => new { product.ProductName, product.Category, OutOfStock = ProductList.Any(p => p.UnitsInStock == 0) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //03

            var result = ProductList.Select(product => new { product.ProductName, product.Category, InStock = ProductList.Where(p => p.Category == product.Category).All(p => p.UnitsInStock > 0) });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }





            #endregion

        }
    }
}
