using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Monster
    {
        public string Name;
        public int Hp;
        public int Damage;
        public int Armor;
        public bool Life = true;
        

        public Monster(string name, int hp, int damage, int armor)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            Armor = armor;
        }

    }
}
