namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// An interface defining a Wizard enemy.
    /// </summary>
    public interface IWizard : IEnemy
    {
        /// <summary>
        /// The name of the Wizard's attack spell.
        /// </summary>
        string AttackSpell { get; set; }
    }
}
