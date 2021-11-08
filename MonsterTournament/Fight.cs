using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Fight
    {
        public void Life(Monster m1, Monster m2) //Проверка на жизнь
        {
            if (m1.Hp <= 0)
            {
                m1.Life = false;
                return;
            }
            if (m2.Hp <= 0)
            {
                m2.Life = false;
            }
        }

        public void GetDamage(Monster m1, Monster m2) //Получить дамаг
        {
            m1.Hp = (m1.Hp + m1.Armor / 2) - m2.Damage;
            m2.Hp = (m2.Hp + m2.Armor / 2) - m1.Damage;
        }

        public Monster Round(Pair p) //Раунд между двумя монстрами
        {
            while (true)
            {
                GetDamage(p.First, p.Second);
                Life(p.First, p.Second);
                if (p.First.Life == false)
                {
                    return p.Second;
                }

                if (p.Second.Life == false)
                {
                    return p.First;
                }

            }
            
        }
    }
}
