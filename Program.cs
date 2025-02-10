using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LINQTask.ListGenerators;

namespace LINQTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1)
            #region 1. Find all products that are out of stock.
            //query exp
            //var res = from p in ProductList 
            //          where p.UnitsInStock == 0
            //          select p;

            ////Fluent exp
            //var res2 = ProductList.Where( p => p.UnitsInStock == 0);

            ////Printing Data
            //foreach(Product p  in res2)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var res = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            //foreach (Product p in res)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res = Arr.Where( (x,i) => x.Length < i  );

            //foreach (string x in res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            //(2)
            #region 1. Get first Product out of Stock 

            //var res = ProductList.First(p => p.UnitsInStock== 0);
            //Console.WriteLine(res);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res = ProductList.FirstOrDefault(p => p.UnitPrice > 1000 );
            //Console.WriteLine(res);

            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Where( x => x > 5).Skip(1).Take(1);

            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //(3)

            #region 1. Find the unique Category names from Product List

            //var res = ProductList.Select( p => p.Category ).Distinct() ;
            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Concat(CustomerList.Select(c => c.CustomerName[0])).Distinct();

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var res = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates

            //var res = ProductList.Select(p => p.ProductName.Substring(0, 3)).Concat(CustomerList.Select(c => c.CustomerName.Substring(0, 3)));

            //foreach (var p in res)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            //(4)

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Count( e => e % 2 == 1);

            //Console.WriteLine(res);
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var res = CustomerList.Select( c => new { Name =  c.CustomerName, NumberOfOrders =  c.Orders.Length } );

            //foreach (var item in res) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has
            //var res = ProductList.GroupBy(p => p.Category).Select( g => new { Category= g.Key , NumOfProducts = g.Count() }).ToList();

            //foreach (var item in res) 
            //{ 
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum();
            //Console.WriteLine(sum);

            #endregion

            #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Aggregate(0,(sumOfChars, word) => sumOfChars += word.Length);
            //Console.WriteLine(res);
            #endregion

            #region 6. Get the total units in stock for each product category.
            //var res = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            //foreach (var x in res) { Console.WriteLine(x); }
            #endregion

            #region 7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var shortestWordLength = File.ReadAllLines("dictionary_english.txt").Min(word => word.Length);
            //Console.WriteLine(shortestWordLength);
            #endregion

            #region 8. Get the cheapest price among each category's products
            //var res = ProductList.GroupBy(p => p.Category)
            //                  .Select(g => new { Category = g.Key, CheapestProduct = g.OrderBy(p => p.UnitPrice).Select(p =>p.ProductName ).FirstOrDefault() });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 9. Get the products with the cheapest price in each category (Use Let)
            //var res = from p in ProductList
            //          group p by p.Category into g
            //          let minPrice = g.Min(p => p.UnitPrice)
            //          select new
            //          {
            //              Category = g.Key,
            //              CheapestProduct = g.Select(p => p.ProductName).FirstOrDefault(),
            //          };

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var longestWordLength = File.ReadAllLines("dictionary_english.txt").Max(word => word.Length);
            //Console.WriteLine(longestWordLength);
            #endregion

            #region 11. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new {Category = g.Key,MaxPrice = g.Max(p => p.UnitPrice) });

            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion

            #region 12. Get the products with the most expensive price in each category.
            //var res = ProductList.GroupBy(p => p.Category)
            //                  .Select(g => new { Category = g.Key, MostExpensive = g.OrderByDescending(p => p.UnitPrice).Select(p => p.ProductName).FirstOrDefault() });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var avgLength = File.ReadAllLines("dictionary_english.txt").Select(w => w.Length).Average();
            //Console.WriteLine(avgLength);
            #endregion

            #region 14. Get the average price of each category's products.

            //var res = ProductList.GroupBy(p => p.Category)
            //              .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion


            //(5)
            #region 1. Sort a list of products by name
            //var res = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var res = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.OrderBy(d => d.Length).ThenBy(d => d);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            //foreach (var i in res) { Console.WriteLine(i); }
            #endregion


            //(6)
            #region 1. Get the first 3 orders from customers in Washington
            //var res = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Take(3);
            //foreach (var x in res) { Console.WriteLine(x.ToString()); }
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var res = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Skip(2);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((n, index) => n >= index);
            //foreach (var n in res) { Console.WriteLine(n); }
            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var n in res) { Console.WriteLine(n); }

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile((n, index) => n >= index);
            //foreach (var n in res) { Console.WriteLine(n); }

            #endregion

            //(7)

            #region 1. Return a sequence of just the names of a list of products.
            //var productNames = ProductList.Select(p => p.ProductName);

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w => new { Uppercase = w.ToUpper(), Lowercase = w.ToLower() });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            // var productDetails = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });

            #endregion

            #region 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var positionsMatch = Arr.Select((value, index) => new { Number = value, InPlace = value == index });
            //foreach (var item in positionsMatch) { Console.WriteLine(item); }
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = numbersA.SelectMany(a => numbersB.Where(b => a < b), (a, b) => new { a, b });
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            //foreach (var o in res) { Console.WriteLine(o); }
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var res = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var o in res) { Console.WriteLine(o); }
            #endregion


            //(8)

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var containsEi = File.ReadAllLines("dictionary_english.txt").Any(word => word.Contains("ei"));
            //Console.WriteLine(containsEi);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var outOfStockCategories = ProductList.GroupBy(p => p.Category)
            //                        .Where(g => g.Any(p => p.UnitsInStock == 0));
            // foreach (var group in outOfStockCategories)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var inStockCategories = ProductList.GroupBy(p => p.Category)
            //                    .Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var group in inStockCategories)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product.ProductName} - Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion


            //(9)

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //int[] arr = { 1, 34, 5, 6, 7, 8, 6, 4, 2, 2, 3, 5, 6, 7, 8, 9, 0, 76, 44, 45, 4, 5, 3, 4, 34, 45, 45, 40, 35, 36, 25, 12, 12, 3, 5, 8 };
            //var res = arr.GroupBy(n => n % 5)
            //                            .OrderBy(g => g.Key);

            //foreach (var g in res)
            //{
            //    Console.WriteLine($"Remainder of {g.Key}:");
            //    foreach (var number in g)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter.
            //var res = File.ReadAllLines("dictionary_english.txt").GroupBy(word => word[0])
            //                              .OrderBy(g => g.Key) ;

            //foreach (var group in res)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 3. Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            #endregion




            //test

            var res = CustomerList.Where(c=>c.Orders.Length > 10).SelectMany(c => c.Orders).Select(o=>o.Total);

            foreach (var item in res) { Console.WriteLine(item); }












            #region Extesion Method
            ////adding extention method to int datatype
            //int x = 41;
            //int y = x.half();
            //Console.WriteLine(y);
            #endregion

            #region Anonymouse Type 
            //var st1 = new { id = 1, name = " tarek", age = 99 };
            //var st2 = new { id = 2, name = "Ahmed", age = 54 };
            //var st3 = new { id = 2, name = "Ahmed", age = 54 , grade = 67 };

            //Console.WriteLine(st1.GetType());
            //Console.WriteLine(st2.GetType());
            //Console.WriteLine(st3.GetType());
            #endregion


        }
    }
}
