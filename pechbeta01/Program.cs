/*
 * Student ID :1690700131
 * Name       : jirayu usaneesawatchai
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace pech_beta01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "dew";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("dew takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");

           
        }
    }
}