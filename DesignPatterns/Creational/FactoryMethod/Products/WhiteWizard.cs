namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Wizard enemy (concrete Product).
    /// </summary>
    internal class WhiteWizard : Enemy, IWizard
    {
        public string AttackSpell { get; set; }
    }
}
