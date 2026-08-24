/*
 * Student ID :1670704335
 * Name       :
 * Section    :
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
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


    }
    internal class Program2
    {
        static void Main(string[] args)
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


    }
}
    
