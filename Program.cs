using System;
using System.Collections.Generic;



namespace test01
{
    class Program
    {
        public class Product
        {
            public String ID { get; set; }
            public String Name { get; set; }
        }
        private static List<Product> _p = new List<Product>();

        static void Main(string[] args)
        {

            Console.WriteLine("=================");
            Console.WriteLine("會員清單");
            _p.Add(new Product { ID = "001", Name = "A001" });
            _p.Add(new Product { ID = "002", Name = "A002" });
            _p.Add(new Product { ID = "003", Name = "A003" });

            foreach (var i in _p)
            {

                Console.WriteLine(i.ID + "->" + i.Name);

            }

            Console.WriteLine("=================");


            var s1 = 0;
            //var m = new Members("001", "B001");
            var m = new Members();

            s1 = m.AddDB("001", "B001");
            Console.WriteLine("001" + (s1 > 0 ? "新增成功..." : "新增失敗..."));
            s1 = m.AddDB("002", "B002");
            Console.WriteLine("002" + (s1 > 0 ? "新增成功..." : "新增失敗..."));
            s1 = m.AddDB("003", "B003");
            Console.WriteLine("003" + (s1 > 0 ? "新增成功..." : "新增失敗..."));
            s1 = m.AddDB(new Members.DB { ID = "004", Name = "B004" });
            Console.WriteLine("004" + (s1 > 0 ? "新增成功..." : "新增失敗..."));

            Console.WriteLine("=================");
            Console.WriteLine("會員清單");
            m.ShowDB();

            Console.WriteLine("=================");
            var s2 = 0;

            s2 = m.UpdateDB("001", "C001");
            Console.WriteLine("001" + (s2 > 0 ? "修改成功..." : "修改失敗..."));

            s2 = m.DeleteDB("002");
            Console.WriteLine("002" + (s2 > 0 ? "刪除成功..." : "刪除失敗..."));


            Console.WriteLine("=================");
            Console.WriteLine("會員清單");
            m.ShowDB();




        }



    }
}
