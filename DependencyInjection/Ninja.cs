using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Ninja
    {

        string name;
        IWeapon currentWeapon;

        public Ninja(string name, IWeapon weapon)
        {

            this.name = name;
            this.currentWeapon = weapon;
        }

        public void ChangeWeapon(IWeapon newWeapon)
        {
            this.currentWeapon = newWeapon;
        }

        public bool Walk(string direction,int distance)
        {
            return true;
        }

        public bool Attack(double distance)
        {
            return currentWeapon.Attack(distance);
        }

        public void Reload()
        {
            currentWeapon.Reload();
        }
    }
}
