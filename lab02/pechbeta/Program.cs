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

            //ตัวละครที่ 1: กัปตัน
            string p1Name = "sova";
            int p1Hp = 450;
            float p1Damage = 55.5f;
            char p1Grade = 'A';
            bool p1IsAlive = true;
            double p1critMultiplier = 1.75;

            Console.WriteLine($"Name: {p1Name}");
            Console.WriteLine($"HP: {p1Hp}");
            Console.WriteLine($"Damage: {p1Damage}");
            Console.WriteLine($"Grade: {p1Grade}");
            Console.WriteLine($"Is Alive: {p1IsAlive}");

            //ตัวละครที่ 2: พลปืนใหญ๋
            string p2Name = "molten";
            int p2Hp = 625;
            float p2Damage = 75.5f;
            char p2Grade = 'B';
            bool p2IsAlive = true;
            double p2critMultiplier = 1.65;

            Console.WriteLine($"Name: {p2Name}");
            Console.WriteLine($"HP: {p2Hp}");
            Console.WriteLine($"Damage: {p2Damage}");
            Console.WriteLine($"Grade: {p2Grade}");
            Console.WriteLine($"Is Alive: {p2IsAlive}");

            //ตัวละครที่ 3: พลปืนกลเล็ก01
            string p3Name = "ploydaw";
            int p3Hp = 375;
            float p3Damage = 40.5f;
            char p3Grade = 'c';
            bool p3IsAlive = true;
            double p3critMultiplier = 1.5;

            Console.WriteLine($"Name: {p3Name}");
            Console.WriteLine($"HP: {p3Hp}");
            Console.WriteLine($"Damage: {p3Damage}");
            Console.WriteLine($"Grade: {p3Grade}");
            Console.WriteLine($"Is Alive: {p3IsAlive}");

            //ตัวละครที่ 4: พลปืนกลเล็ก02
            string p4Name = "John";
            int p4Hp = 355;
            float p4Damage = 35.5f;
            char p4Grade = 'D';
            bool p4IsAlive = true;
            double p4critMultiplier = 1.5;

            Console.WriteLine($"Name: {p4Name}");
            Console.WriteLine($"HP: {p4Hp}");
            Console.WriteLine($"Damage: {p4Damage}");
            Console.WriteLine($"Grade: {p4Grade}");
            Console.WriteLine($"Is Alive: {p4IsAlive}");
        }
    }
}