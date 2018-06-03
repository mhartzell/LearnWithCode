using PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products;

namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Factories
{
    /// <summary>
    /// A concrete implemention of an <see cref="IWorldFactory"/>.
    /// </summary>
    internal class IceWorldFactory : WorldFactory
    {
        public override GameWorld ConstructWorld()
        {
            return new GameWorld
            {
                Dragon = new IceDragon
                {
                    BreathesFire = false,
                    Name = "Ice Dragon",
                    Strength = 15
                },

                Troll = new IceTroll
                {
                    IsStone = true,
                    Name = "Ice Troll",
                    Strength = 16
                },

                Wizard = new WhiteWizard
                {
                    AttackSpell = "Ice Blast",
                    Name = "White Wizard",
                    Strength = 8
                }
            };
        }
    }
}
