using ILootClass;
using System.Drawing;

namespace Minecraft.Bloecke
{
    internal abstract class Basisblock : ILoot
    {
        protected int Staerke { get; set; }
        protected ConsoleColor Farbe { get; set; }

        public virtual int Abbauen(Tools tool)
        {
            Console.WriteLine("Block mit {0} zerstört", tool.ToString());
            return 0;
        }
        public static void DoSomething(ILoot loot)
        {
            loot.GibLoot();
        }
        public int GibLoot()
        {
            Console.WriteLine("Loot Bekommen!");
            return 0;
        }
    }
}
