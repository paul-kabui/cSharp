namespace DotNetProgram.Basics.CtorInit{
    public class Book(int id)
    {
        // -Bellow are book Properties
        // -Properties starts with a capital letter
        // -Variables starts with small letter but camel Case
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Id { get; private set; } = id; //id is intiallized within the ctor
    }

    class Program{
        //to create a instance of book, this is how its done
        public static void Maink(string[] args){
            Book book1 = new(16){Title="CAucasian",Author="Uknown"}; 
            book1.Title = "RiverAndTheSource";
            Console.WriteLine(book1.Title);
        }
    }
}