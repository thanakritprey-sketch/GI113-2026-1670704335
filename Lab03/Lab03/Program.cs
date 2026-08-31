using System.Runtime.Intrinsics.Arm;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine ($"===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nBoss Name: {bossName}\nRank: {rank}\nLevel: {level}\nMax HP: {maxHp}\nCurrent HP: {currentHp}\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            Console.WriteLine($"\n---- - Implicit Conversion: HP as double ");
            double currentHpDouble = currentHp;
            Console.WriteLine($"Current HP as double: {currentHpDouble}");

            Console.WriteLine($"\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Exact HP Percent: {hpPercent}%");

            Console.WriteLine($"\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power as Int: {attackPower}");

            Console.WriteLine($"\n----- Cast vs Convert: Crit Multiplier -----");
            int critMultiplierInt = (int)critMultiplier;
            Console.WriteLine($"Critical Multiplier as Int: {critMultiplier}");
        }
    }
}
