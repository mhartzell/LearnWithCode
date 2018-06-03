namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Wizard enemy (concrete Product).
    /// </summary>
    internal class RedWizard : Enemy, IWizard
    {
        public string AttackSpell { get; set; }
    }
}
