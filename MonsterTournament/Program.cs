using System;
using System.Collections.Generic;

namespace MonsterTournament
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DataEntry dataEntry = new DataEntry();
            int count = dataEntry.DegreeOfTwo();
            List<Monster> monsters = new List<Monster>(dataEntry.ListMonsters(count));

            DataOutput dataOutput = new DataOutput();
            dataOutput.PrintMonsters(monsters);

            Fight fight = new Fight();

            int round = 1;

            while (monsters.Count != 1)
            {
                List<Pair> pairs = new List<Pair>();
                
                

                for (int i = 0; i < monsters.Count / 2;)
                {
                    Pair p = new Pair();
                    p.ChoosePair(monsters);
                    pairs.Add(p);
                    monsters.Remove(p.First);
                    monsters.Remove(p.Second);
                }

                dataOutput.ListOfPairs(pairs, round);

                List<Monster> win = new List<Monster>();
                

                foreach (var i in pairs)
                {
                    win.Add(fight.Round(i));
                }
                dataOutput.ListOfWinners(win, round);
                monsters = win;
                round++;
            }

            dataOutput.TheMainWinner(monsters[0]);



            Console.ReadKey();
        }
    }
}
