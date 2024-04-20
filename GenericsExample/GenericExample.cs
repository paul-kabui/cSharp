namespace DotNetProgram.GenericsExample
{
    class GenericsExample
    {
        public static void Hello<T>(T name)
        {
            Console.WriteLine("hello"+name);
        }

        public static S Sum<S>(S num1, S num2)
        {

            dynamic result = num1 + num2;
            return result;
        }
    }

    class Program
    {
        public static void Main()
        {
            GenericsExample.Hello("World");
        }
    }
}