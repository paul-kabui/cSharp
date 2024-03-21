
namespace ASPSTORE.CollectionExamples
{
    public class ArraysMethods
    {   
        public static void ArrayOperation(){
        int[] arr = [1, 2, 3, 4]; //cannt append an array
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(arr.Contains(2)); //contains
        Console.WriteLine(arr.FirstOrDefault(2));
        Console.WriteLine(arr.Sum());
        string? arrString = arr.ToString();
        Console.WriteLine(arrString);
            
    }
        public static void ArrayEqualityCheck()
        {
            //diffrent  ways of diclaring an array
            int[] intArrays = [1,2,3,4];
            var ints = new int[]{1,2,3,4};
            Console.WriteLine(intArrays.Equals(ints)); //compare by reference
            Console.WriteLine(intArrays.SequenceEqual(ints)); //compare by value
            Console.WriteLine(intArrays.Length);

        }
    }
    
}