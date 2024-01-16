namespace DTO;

public class SuperHero{
    public string id { get; set; }
    public string name {get; set;}
    public Powerstats powerstats {get; set;}


    public SuperHero(string id, string name, Powerstats powerstats) {
        this.id = id;
        this.name = name;
        this.powerstats = powerstats;
    }
}