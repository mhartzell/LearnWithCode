namespace PMasta.LearnWithCode.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// A concrete implementation of an <see cref="IBasketballPlayer"/>.
    /// </summary>
    /// <remarks>This is the Product produced by the Prototype.</remarks>
    public class BasketballPlayer : IBasketballPlayer
    {
        public string Name { get; set; }

        public PositionType Position { get; set; }

        public IBasketballPlayer Clone()
        {
            // This example is trivial and simply returns a memberwise clone of the Prototype.  The Clone
            // operation can be significantly more complex.
            return this.MemberwiseClone() as IBasketballPlayer;
        }
    }
}
