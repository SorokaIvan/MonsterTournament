using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Pair
    {
        public Monster First;
        public Monster Second;

        public void ChoosePair(List<Monster> monsters)
        {
            Random random = new Random();
            int value1 = random.Next(0, monsters.Count - 1);
            int value2 = random.Next(0, monsters.Count - 1);
            if (value1 == value2)
            {
                if (value2 == monsters.Count - 1)
                {
                    value2 = (monsters.Count - 1) - 1;
                }
                else
                {
                    value2 += 1;
                }
            }
            First = monsters[value1];
            Second = monsters[value2];
        }
    }
}
