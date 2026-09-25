using Minecraft;
using Minecraft.Bloecke;
using System.Drawing;

namespace Minecraft
{
    public class MinecraftGame
    {
        Erdblock erde;
        Holzblock holz;
        Steinblock stein;
        Tools tool;
        int BlockAnzahl;
       
        public MinecraftGame(Tools tool)
        {
            erde = new Erdblock();
            holz = new Holzblock();
            stein = new Steinblock();
            this.tool = tool;
        }

        public void Abbauen()
        {
            Basisblock[] bloecke = { erde, holz, stein };
            foreach (Basisblock block in bloecke)
            {
                BlockAnzahl += block.Abbauen(tool);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Main()
        {
            Console.WriteLine("Tool:");
            Console.WriteLine("1 ... Hände");
            Console.WriteLine("2 ... Schaufel");
            Console.WriteLine("3 ... Axt");
            Console.WriteLine("4 ... Spitzhacke");
            Tools tool = (Tools)Convert.ToInt32(Console.ReadLine());

            MinecraftGame game = new MinecraftGame(tool);
            game.Abbauen();
        }
    }
}