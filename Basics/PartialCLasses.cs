namespace DotNetProgram.Basics
{

    public class BaseClass{
        public  static void BaseMethod(){
            Console.WriteLine("This is the base method");
        }
    }
    public partial class PartialClass: BaseClass
      {
        public static void ExampleMethod(){
            Console.WriteLine("partial class 1");
        }
    }

    public partial class PartialClass{
        public static void AnotherExampleMethod(){
            Console.WriteLine("Method call from the second declaration.");
        }
    }

    class Program{
        public static void Maink(string[] args){
            PartialClass.ExampleMethod();
            PartialClass.AnotherExampleMethod();
            PartialClass.BaseMethod();
        }
    }
}