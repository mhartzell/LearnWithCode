using PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products;

namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Factories
{
    /// <summary>
    /// A concrete implemention of an <see cref="IWorldFactory"/>.
    /// </summary>
    internal class DarkWorldFactory : WorldFactory
    {
        public override GameWorld ConstructWorld()
        {
            return new GameWorld
            {
                Dragon = new GoldDragon
                {
                    BreathesFire = true,
                    Name = "Gold Dragon",
                    Strength = 23
                },

                Troll = new DarkTroll
                {
                    IsStone = false,
                    Name = "Dark Troll",
                    Strength = 21
                },

                Wizard = new DemonWizard
                {
                    AttackSpell = "Soul Crush",
                    Name = "Demon Wizard",
                    Strength = 11
                }
            };
        }
    }
}
