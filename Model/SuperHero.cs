namespace Model;

public class SuperHero {

    public string id { get; set; }
    public string name {get; set;}

    public SuperHero(string name) {
        this.name = name;
    }
}