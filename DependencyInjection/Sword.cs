using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Sword : IWeapon
    {
        public bool Attack(double distance)
        {
            if (distance < 1.5)
                return true;
            else
              return false;
        }

        public void Reload()
        {
            
        }
    }
}
