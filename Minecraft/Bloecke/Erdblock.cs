using ILootClass;

namespace Minecraft.Bloecke
{
    internal class Erdblock : Basisblock
    {
        public Erdblock() 
        {
            Staerke = 10;
            Farbe = ConsoleColor.Green;
        }
        public override int Abbauen(Tools tool)
        {
            bool GibtLoot = false;
            Console.ForegroundColor = Farbe;
            while(Staerke > 0)
            {
                Console.WriteLine("Grab...");
                Thread.Sleep(150);

                switch (tool)
                {
                    case Tools.Haende:
                        Staerke--;
                        GibtLoot = true;
                        break;
                    case Tools.Schaufel:
                        Staerke -= 5;
                        GibtLoot = true;
                        break;
                    case Tools.Axt:
                        Staerke -= 2;
                        GibtLoot = true;
                        break;
                    case Tools.Spitzhacke:
                        Staerke -= 2;
                        GibtLoot = true;
                        break;
                    default:
                        Staerke--;
                        break;
                }
            }
            if (GibtLoot)
            {
                ErdeAusgabe loot = new();
                DoSomething(loot);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class ErdeAusgabe : LootAusgabe
    {
        public override int GibLoot()
        {
            Console.WriteLine("Erde Bekommen!");
            return 1;
        }
    }
}
