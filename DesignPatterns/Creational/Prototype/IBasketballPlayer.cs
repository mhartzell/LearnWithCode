namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Defines an interface for a basketball player.
    /// </summary>
    public interface IBasketballPlayer : IPrototype<IBasketballPlayer>
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The position of the player.
        /// </summary>
        PositionType Position { get; set; }
    }
}
