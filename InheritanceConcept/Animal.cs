namespace InheritanceConcept{
    class Animal(string Name, string Sound)
    {
        internal string Name{get; set;} = Name; //used internal access modifier so as to be accessed in the animalInfo Classn
        private string Sound{get;set;} = Sound;

        public string MakeSound(){
            return this.Sound;
        }
    }

    class Dog(string Name, string Sound, int Age) : Animal(Name, Sound)
    {
        internal int Age{get;} = Age;
       
        public void DisplayInfo(){
            Console.WriteLine($"{Name} is {Age} and makes {MakeSound()}");
        }
    }

    class AnimalInfo{
        public static void Mainu(String[] args)
        {
            Dog tom = new("Tom","Woof",12);
            tom.DisplayInfo();
            Console.WriteLine( tom.Name);
            Console.WriteLine( tom.Age);
        } 
    }
}