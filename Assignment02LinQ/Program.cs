namespace Assignment02LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            #region Question01
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            #endregion
            #region Question02
            //int pagenumber = 2;
            //int pagesize = 5;
            //var result = ProductList.Skip((pagenumber - 1) * pagesize).Take(pagesize);

            #endregion
            #region Question03

            //var result = ProductList.TakeWhile(p => p.UnitPrice < 25.00M);

            #endregion
            #region Question04
            //var result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitInStock > 0)
            //Console.WriteLine(result);
            #endregion
            #region Question05
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);
            #endregion
            #region Question06
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question07
            //var result = ProductList.GroupBy(p => p.Category);
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"Category : {item.Key}");
            //    foreach(var product in item)
            //    {
            //        Console.WriteLine($"Product Name :{product.ProductName}");
            //    }
            //}
            #endregion
            #region Question08

            //var result = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category Name : {item.Key}");
            //    Console.WriteLine($"Products Count : {item.Count()}");
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            #endregion
            #region Question09
            //var result = from c in CustomerList
            //             group c by c.Country
            //            into CustomerCountries
            //             select new
            //             {
            //                 Country = CustomerCountries.Key,
            //                 Count = CustomerCountries.Count(),


            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region Question10
            #endregion


        }
    }
}
