using System.Security.Cryptography.X509Certificates;

namespace DotNetProgram.LinqCocepts
{
    public class LinqExample2
    {
        public static void Main(string[] args)
        {
            int[] numbers = [1,2,3,4,5];
            string[] words = ["one","two","three","four","five"];
            Dictionary<string, string> dict = [];
            var lst = numbers.Select(n => n *2)
                .Where(n => n < 8)
                .OrderBy(n => n)
            ;
            foreach(var number in lst)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbers.FirstOrDefault(n => n >= 2));

            var ziplst = words.Zip(numbers,(n,w) => n+","+w);
            foreach(var items in ziplst)
            {
                var itemsArr = items.Split(",");
                dict.Add(itemsArr[0],itemsArr[1]);
            }
            foreach(var keys in dict.Keys)
            {
                Console.WriteLine(dict[keys]);
            }

            List<string> lst1 = ["oe","two","three"];
            Dictionary<int,string> dict2 = lst1.ToDictionary(xf => xf.Length);
            foreach(var items in dict2)
            {
                Console.WriteLine(items);
            }
        }
    }
}