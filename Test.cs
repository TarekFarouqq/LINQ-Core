using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTask
{/*
    internal class Test
    {
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQQueries
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Sample data for some queries
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                string[] digitWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numbersB = { 1, 3, 5, 7, 8 };

                // Load external data
                List<Product> products = ListGenerators.GetProducts();
                List<Customer> customers = ListGenerators.GetCustomers();

                #region LINQ - Filtering Operators
                var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);
                var inStockCostlyProducts = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
                var shorterNameDigits = digitWords.Where(word => word.Length < int.Parse(new string(word.Where(char.IsDigit).ToArray())));

                #endregion

                #region LINQ - Element Operators
                var firstOutOfStockProduct = products.FirstOrDefault(p => p.UnitsInStock == 0);
                var expensiveProduct = products.FirstOrDefault(p => p.UnitPrice > 1000);
                var secondNumberGreaterThanFive = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();

                #endregion

                #region LINQ - Set Operators
                var uniqueCategories = products.Select(p => p.Category).Distinct();
                var uniqueFirstLetters = products.Select(p => p.ProductName[0])
                    .Union(customers.Select(c => c.CompanyName[0]));
                var commonFirstLetters = products.Select(p => p.ProductName[0])
                    .Intersect(customers.Select(c => c.CompanyName[0]));
                var productOnlyFirstLetters = products.Select(p => p.ProductName[0])
                    .Except(customers.Select(c => c.CompanyName[0]));
                var lastThreeCharacters = customers.SelectMany(c => c.CompanyName.TakeLast(3).Select(ch => ch))
                    .Union(products.SelectMany(p => p.ProductName.TakeLast(3).Select(ch => ch)));

                #endregion

                #region LINQ - Aggregate Operators
                var oddNumberCount = numbers.Count(n => n % 2 != 0);
                var customerOrderCounts = customers.Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() });
                var categoryProductCounts = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Count = g.Count() });
                var totalSum = numbers.Sum();
                var totalUnitsByCategory = products.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
                var shortestWordLength = File.ReadAllLines("dictionary_english.txt").Min(word => word.Length);
                var cheapestProductInCategory = products.GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, CheapestProduct = g.OrderBy(p => p.UnitPrice).First() });
                var longestWordLength = File.ReadAllLines("dictionary_english.txt").Max(word => word.Length);
                var mostExpensivePriceByCategory = products.GroupBy(p => p.Category).Select(g => g.Max(p => p.UnitPrice));

                #endregion

                #region LINQ - Ordering Operators
                var sortedByNameProducts = products.OrderBy(p => p.ProductName);
                var sortedProductsByStockDesc = products.OrderByDescending(p => p.UnitsInStock);
                var digitsSortedByLengthThenAlphabetically = digitWords.OrderBy(word => word.Length).ThenBy(word => word);

                #endregion

                #region LINQ - Projection Operators
                var productNames = products.Select(p => p.ProductName);
                var wordsWithUpperLower = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });
                var productsWithPriceProjection = products.Select(p => new { p.ProductName, Price = p.UnitPrice });
                var pairsFromArrays = from a in numbersA
                                      from b in numbersB
                                      where a < b
                                      select new { a, b };
                var ordersUnder500 = customers.SelectMany(c => c.Orders).Where(o => o.Total < 500);
                var ordersFrom1998OrLater = customers.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);

                #endregion

                #region LINQ - Grouping Operators
                var groupByRemainder = numbers.GroupBy(n => n % 5).Select(g => new { Remainder = g.Key, Numbers = g });
                var groupWordsByFirstLetter = File.ReadAllLines("dictionary_english.txt").GroupBy(word => word[0]);
                var groupedAnagrams = Arr.GroupBy(w => new string(w.Trim().OrderBy(c => c).ToArray()));

                #endregion
            }
        }
    }*/

}

