namespace InheritanceConcept
{
    //init enforces immutability
    //always a good way to use private modifier in fields
    class Vehicle(string Name, string Model, int YearsUsed)
    {
        private string Name{get; init;} = Name;
        private string Model{get; init;} = Model;
        protected int YearsUsed{get;set;} = YearsUsed; //can be change/modifield
    }

    class Car(string Name, string Model,decimal Price, int YearsUsed, int MileAge):Vehicle(Name,Model,YearsUsed)
    {
        private readonly decimal Price = Price;
        private decimal MileAge{get; set;} = MileAge;
        public decimal CalculateCurrentValue()
        {   //current value = intialPrice/(yearsUsed +(0.1*mileage) just an example
            decimal CurrentValue = Price / (YearsUsed + (9M * MileAge));
            return CurrentValue;
        }
    }

    public class VehiclePriceCalculator{
        public static void Main3(String[] args){
            var Bmw = new Car("BMW","CX2",20000000,2,2000);
            // Console.WriteLine(Bmw.Price);
            Console.WriteLine(Bmw.GetType());

            Console.WriteLine(Bmw.CalculateCurrentValue());
            Console.WriteLine(typeof(Car));
            Console.WriteLine(nameof(Bmw));
        }
    }
}