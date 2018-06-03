namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// An interface defining a Troll enemy.
    /// </summary>
    public interface ITroll : IEnemy
    {
        /// <summary>
        /// True if the troll is currently turned to stone.
        /// </summary>
        bool IsStone { get; set; }
    }
}
