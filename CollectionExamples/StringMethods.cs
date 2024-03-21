namespace ASPSTORE{
    public class StringMethods
{
     public static void StringOperations()
    {
        string str = "hello world";
        string str2 = "hello world";
        Console.WriteLine(String.Equals(str, str2));
        Console.WriteLine(str == str2);
        string firstName = "paul";
        string secondName = "Mwangi";
        Console.WriteLine($"My name is {firstName}{secondName}");
        
        Console.WriteLine(str.Insert(3, "p"));
        Console.WriteLine(str.Replace("l","p"));
        Console.WriteLine(String.Format("my first name:{0}, and second name:{1}",firstName, secondName)); //formating
        Console.WriteLine(@"\nhello\t there");
    }
}
}