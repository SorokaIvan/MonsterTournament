using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class DataOutput
    {
        public void PrintMonsters(List<Monster> monsters)
        {
            Console.WriteLine("Монстры, которе будут принимать участвие в турнире:");
            Console.WriteLine();
            foreach (var i in monsters)
            {
                Console.Write($"Имя: {i.Name}\tХП: {i.Hp}\tДамаг: {i.Damage}\tБроня: {i.Armor}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите ENTER, что бы продолжить...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public void ListOfPairs(List<Pair> p, int round)
        {
            Console.WriteLine($"В {round} раунде пары распределились:");
            Console.WriteLine();
            foreach (var i in p)
            {
                Console.WriteLine($"{i.First.Name} vs {i.Second.Name}");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите ENTER, что бы продолжить...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public void ListOfWinners(List<Monster> m, int round)
        {
            Console.WriteLine($"В {round} раунде ПОБЕДИЛИ:");
            Console.WriteLine();
            foreach (var i in m)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите ENTER, что бы продолжить...");
            Console.WriteLine();
            Console.ReadKey();
        }

        public void TheMainWinner(Monster m)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Главным ПОБЕДИТЕЛЕМ СТАНОВИТЬСЯ:");
            Console.WriteLine();
            Console.WriteLine(m.Name);
            Console.WriteLine("-------------------------------------");
        }
    }
}
