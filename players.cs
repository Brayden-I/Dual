using Weapons;

namespace Players;

public class Player
{
    public string name;
    public int health;
    public Weapon weapon;

    public Player(string Name, Weapon Weapon, int Health = 100)
    {
        name = Name;
        health = Health;
        weapon = Weapon;
    }

    public string takeDamage(int Amount)
    {
        health -= Amount; //Hurt player by Amount
        if (health < 0)
            health = 0;
        return $"{name} took {Amount} damage! Health: {health}";
    }

    public bool isAlive()
    {
        return health > 0;
    }
}
