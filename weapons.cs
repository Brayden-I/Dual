using System;
using Players;

namespace Weapons;

public class Weapon
{
    string type;
    string action;


    public Weapon(string Type, string Action)
    {
        type = Type;
        action = Action;
    }

    public string Strike(int Damage)
    {
        return $"The {type} {action}. It causes {Damage} damage.";
    }
}
