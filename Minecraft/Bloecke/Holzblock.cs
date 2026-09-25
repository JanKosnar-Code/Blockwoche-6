using ILootClass;

namespace Minecraft.Bloecke
{
    internal class Holzblock : Basisblock
    {
        public Holzblock()
        {
            Staerke = 15;
            Farbe = ConsoleColor.DarkRed;
        }
        public override int Abbauen(Tools tool)
        {
            bool GibtLoot = false;
            Console.ForegroundColor = Farbe;
            while (Staerke > 0)
            {
                Console.WriteLine("Hack...");
                Thread.Sleep(200);

                switch (tool)
                {
                    case Tools.Haende:
                        Staerke--;
                        GibtLoot = true;
                        break;
                    case Tools.Schaufel:
                        Staerke -= 2;
                        break;
                    case Tools.Axt:
                        Staerke -= 5;
                        GibtLoot = true;
                        break;
                    case Tools.Spitzhacke:
                        Staerke -= 2;
                        break;
                    default:
                        Staerke--;
                        break;
                }
            }
            if (GibtLoot) 
            {
                HolzAusgabe loot = new();
                DoSomething(loot);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class HolzAusgabe : LootAusgabe
    {
        public override int GibLoot()
        {
            Console.WriteLine("Holz Bekommen!");
            return 1;
        }
    }
}
