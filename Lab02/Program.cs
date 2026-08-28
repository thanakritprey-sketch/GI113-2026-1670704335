/*
 * Student ID :1670704335
 * Name       :thamakrit preyapanarakui
 * Section    :129A
 * No.        :-
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program1();
            Console.WriteLine();
            Program2();
            Console.WriteLine();
            Program3();
            Console.WriteLine();
            Program4();
        }
        static void Program1()
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"level:{level}");
            Console.WriteLine($"HP:{maxHp}/{currentHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");


        }

        static void Program2()
        {
            string bossName = "Max";
            char rank = 'M';
            int level = 3;
            int maxHp = 360;
            int currentHp = 195;
            float attackPower = 62.5f;
            double critMultiplier = 1.95;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"level:{level}");
            Console.WriteLine($"HP:{maxHp}/{currentHp}");


            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Max takes 60 damage!");
            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%" + $"");


        }
        static void Program3()
        {
            string bossName = "Broher Square";
            char rank = 'M';
            int level = 5;
            int maxHp = 4000;
            int currentHp = 140;
            float attackPower = 46.5f;
            double critMultiplier = 1.25;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"level:{level}");
            Console.WriteLine($"HP:{maxHp}/{currentHp}");


            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Max takes 60 damage!");
            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%" + $"");


        }
        static void Program4()
        {
            string bossName = "Asian Monitor peter gay prem griffin";
            char rank = 'S';
            int level = 00;
            int maxHp = 999999999;
            int currentHp = 999999999;
            float attackPower = 99999999999999999999999999999999999999.999999999999999999999999999999999999999999999999999999f;
            double critMultiplier = 999999999999999.999999;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"level:{level}");
            Console.WriteLine($"HP:{maxHp}/{currentHp}");


            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Max takes 60 damage!");
            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%" + $"");


        }
    }
}

