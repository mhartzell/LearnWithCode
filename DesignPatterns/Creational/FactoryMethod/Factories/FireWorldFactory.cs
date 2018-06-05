using PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod.Products;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod.Factories
{
    /// <summary>
    /// A concrete implemention of an <see cref="IWorldFactory"/>.
    /// </summary>
    internal class FireWorldFactory : WorldFactory
    {
        public override GameWorld ConstructWorld()
        {
            return new GameWorld
            {
                Dragon = new FireDragon
                {
                    BreathesFire = true,
                    Name = "Fire Dragon",
                    Strength = 10
                },

                Troll = new FireTroll
                {
                    IsStone = false,
                    Name = "Fire Troll",
                    Strength = 12
                },

                Wizard = new RedWizard
                {
                    AttackSpell = "Fireball",
                    Name = "Red Wizard",
                    Strength = 6
                }
            };
        }
    }
}
