using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Gun : IWeapon
    {
        int ammunitationLeft;

        public Gun()
        {
            ammunitationLeft = 6;
        }
        public bool Attack(double distance)
        {
            if (ammunitationLeft > 0)
                ammunitationLeft--;

            if (distance < 25)
                return true;
            else
                return false;
        }

        public void Reload()
        {
            ammunitationLeft = 6;
        }
    }
}
