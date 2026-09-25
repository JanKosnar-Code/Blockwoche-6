namespace ILootClass
{
    public interface ILoot
    {
        public int GibLoot();
    }
    public class LootAusgabe : ILoot
    {
        public virtual int GibLoot()
        {
            Console.WriteLine("Loot Bekommen!");
            return 0;
        }
    }
}