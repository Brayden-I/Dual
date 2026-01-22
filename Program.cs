using System.Diagnostics;
using System.Security;
using Players;
using Weapons;

namespace Dual;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Console Duals!\n");

        //INITIALIZE
        string attackerName;
        string attackerWeapon;
        string attackerAction;

        string defenderName;
        string defenderWeapon;
        string defenderAction;

        //Player 1
        do
        {
            Console.WriteLine("Please fill all the fields");
            Console.Write("What should the attacker's name be: ");
            attackerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What should the attacker's Weapon be: ");
            attackerWeapon = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What should the attacker's Action be: ");
            attackerAction = Console.ReadLine();
            Console.WriteLine();
        }
        while (string.IsNullOrWhiteSpace(attackerName) || string.IsNullOrWhiteSpace(attackerWeapon) || string.IsNullOrWhiteSpace(attackerAction));
        
        Weapon weapon1 = new Weapon(attackerWeapon, attackerAction);
        Player player1 = new Player(attackerName, weapon1);

        //Player 2
        do
        {
            Console.Write("What should the defender's name be: ");
            defenderName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What should the defender's Weapon be: ");
            defenderWeapon = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What should the defender's Action be: ");
            defenderAction = Console.ReadLine();
            Console.WriteLine();
        }
        while (string.IsNullOrWhiteSpace(defenderName) || string.IsNullOrWhiteSpace(defenderWeapon) || string.IsNullOrWhiteSpace(defenderAction));

        Weapon weapon2 = new Weapon(defenderWeapon, defenderAction);
        Player player2 = new Player(defenderName, weapon2);

        //DUEL
        Random rand = new Random();
        int damage;

        while (player1.isAlive() && player2.isAlive())
        {
            damage = rand.Next(1, 12);

            //Player 1 attacks Player 2
            Console.WriteLine($"{player2.takeDamage(damage)}");
            Console.WriteLine(weapon1.Strike(damage));
            Console.WriteLine();
            Console.WriteLine("-----");

            Console.ReadLine();

            //Check if Player 2 is defeated
            if (!player2.isAlive())
            {
                Console.WriteLine($"\n{player1.name} wins! {player2.name} has been defeated!");
                Console.WriteLine($"Final Health - {player1.name}: {player1.health}, {player2.name}: {player2.health}");
                break;
            }

            //Player 2 attacks Player 1
            damage = rand.Next(1, 12);
            Console.WriteLine($"{player1.takeDamage(damage)}");
            Console.WriteLine(weapon2.Strike(damage));
            Console.WriteLine();
            Console.WriteLine("-----");

            Console.ReadLine();

            //Check if Player 1 is defeated
            if (!player1.isAlive())
            {
                Console.WriteLine($"\n{player2.name} wins! {player1.name} has been defeated!");
                Console.WriteLine($"Final Health - {player1.name}: {player1.health}, {player2.name}: {player2.health}");
                break;
            }
        }
    }
}
