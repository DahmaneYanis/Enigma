namespace Model;

class SuperHero {
    public string name {get; set;}

    public string intelligence {get; set;}
    public SuperHero(string name, string intelligence) {
        this.name = name;
        Console.WriteLine("intelligence = ", intelligence);
        this.intelligence = intelligence;
    }
}