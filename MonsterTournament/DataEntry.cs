using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class DataEntry
    {
        public int DegreeOfTwo()
        {
            int count = 0;
            while (true)
            {
                Console.Write("Введите количество монстров: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count > 0 && (count & (count - 1)) == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Для корректной работы программы, необходимо ввести число соответствующее степени двойки");
                    Console.WriteLine("Нажмите ENTER, что бы ввести число еще раз!");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }

            return count;
        }
        public List<Monster> ListMonsters(int count)
        {
            string Name;
            int Hp;
            int Damage;
            int Armor;
            var monsters = new List<Monster>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Монстер №{i + 1}");
                Console.WriteLine();
                Console.Write("Введите ИМЯ монстра: ");
                Name = Console.ReadLine();
                Console.Write("Введите ХП монстра: ");
                Hp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ДАМАГ монстра: ");
                Damage = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите БРОНЮ монстра: ");
                Armor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Monster monster = new Monster(Name, Hp, Damage, Armor);
                monsters.Add(monster);
            }
            return monsters;
        }
    }
}
