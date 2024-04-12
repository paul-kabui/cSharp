using System.Text;
using InheritanceConcept;

namespace DotNetProgram.LinqCocepts
{
    class Sales(string salesPerson, int unitSold){
        public string SalesPerson{get; set;} = salesPerson;
        public int UnitSold { get; set; } = unitSold;
    }

    class LinqCocepts{

        public static void Main3(string[] args){
            Sales salesperson1 = new("paul", 51_677);
            Sales salesperson2 = new("esther", 97_580);
            Sales salesperson3 = new("jack", 67_549);
            Sales salesperson4 = new("jane", 52_49);
            Sales salesperson5 = new("Leon", 42_125);
            Sales salesperson6 = new("william", 56_070);

            List<Sales> salesList = [salesperson1,salesperson2,salesperson3,salesperson4,salesperson5,salesperson6];
            var lst = from sales in salesList
                    where sales.UnitSold >= 60_000
                    orderby sales.UnitSold ascending
                    select sales
            ;

            StringBuilder sb = new();
            foreach (var entry in lst)
            {
                sb.AppendLine($"SalesPerson: {entry.SalesPerson} - UnitSold: {entry.UnitSold}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

