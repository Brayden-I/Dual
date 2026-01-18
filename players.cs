using Weapons;

namespace Players;

public class Player
{
    string name;
    int health;
    Weapon weapon;
    

    public Player(string Name, Weapon Weapon, int Health = 100)
    {
        name = Name;
        health = Health;
        weapon = Weapon;
    }

    public string takeDamage(int Amount)
    {
        health -= Amount; //Hurt player by Amount
        return $"{name} took {Amount} damage!";
    }
}
