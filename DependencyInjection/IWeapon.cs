using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IWeapon
    {
        bool Attack(double distance);
        void Reload();
    }
}
