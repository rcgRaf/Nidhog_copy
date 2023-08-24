using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//test
namespace ConsoleApplication13
{
    public static class Dmg
    {
        public static void dealDmg(Player p, int d)
        {
            p.hp = p.hp - d;

        }
    }
}
