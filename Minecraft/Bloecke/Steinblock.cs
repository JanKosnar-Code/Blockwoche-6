using ILootClass;

namespace Minecraft.Bloecke
{
    internal class Steinblock : Basisblock
    {
        public Steinblock()
        {
            Staerke = 20;
            Farbe = ConsoleColor.DarkGray;
        }
        public override int Abbauen(Tools tool)
        {
            bool GibtLoot = false;
            Console.ForegroundColor = Farbe;
            while (Staerke > 0)
            {
                Console.WriteLine("Schlag...");
                Thread.Sleep(250);

                switch (tool)
                {
                    case Tools.Haende:
                        Staerke--;
                        break;
                    case Tools.Schaufel:
                        Staerke -= 2;
                        break;
                    case Tools.Axt:
                        Staerke -= 2;
                        break;
                    case Tools.Spitzhacke:
                        Staerke -= 5;
                        GibtLoot = true;
                        break;
                    default:
                        Staerke--;
                        break;
                }
            }
            if (GibtLoot)
            {
                SteinAusgabe loot = new();
                DoSomething(loot);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class SteinAusgabe : LootAusgabe
    {
        public override int GibLoot()
        {
            Console.WriteLine("Stein Bekommen!");
            return 1;
        }
    }
}