using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create weapons
            Sword sword = new Sword();
            Gun gun = new Gun();

            //Create Ninja
            Ninja ninja = new Ninja("Ninja", gun);
            Console.WriteLine(ninja.Attack(60));

            //Change Weapon
            ninja.ChangeWeapon(sword);
            Console.WriteLine(ninja.Attack(1));

            Console.ReadLine();
        }
    }
}
