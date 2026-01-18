using System;
using Players;

namespace Weapons;

public class weapon
{
    string type;
    string action;


    public weapon(string Type, string Action)
    {
        type = Type;
        action = Action;
    }

    strike(int Damage, player Strike)
    {
        Strike.takeDamage(Damage);
        return random.Next();
    }
}
