using Weapons;

namespace Players;

public class player
{
    string name;
    int health;
    weapon weapon;
    

    public player(string Name, int Health = 100, weapon Weapon)
    {
        name = Name;
        health = Health;
        weapon = Weapon;
    }

    public takeDamage(int Amount)
    {
        health -= Amount; //Hurt player by Amount
        return Amount;
    }
}
