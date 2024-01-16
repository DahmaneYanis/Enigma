namespace DTO;

public class Powerstats {
    public string intelligence {get; set;}
    public string strenght {get; set;}
    public string speed {get; set;}
    public string durability {get; set;}
    public string power {get; set;}
    public string combat {get; set;}

    public Powerstats(string intelligence, string strenght, string speed, string durability, string power, string combat) {
        this.intelligence = intelligence;
        this.strenght = strenght;
        this.speed = speed;
        this.durability = durability;
        this.power = power;
        this.combat = combat;
    }
}