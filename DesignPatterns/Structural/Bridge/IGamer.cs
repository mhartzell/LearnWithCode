namespace PMasta.LearnWithCode.DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Defines a generic video game player.
    /// </summary>
    /// <remarks>
    /// In the Bridge pattern, this interface takes on the role of the Abstraction.  We have a generic game-playin' human,
    /// who may like to play games on a variety of platforms.  The methods on this class would in reality likely be on 
    /// some kind of service, but for this trivial example, the gamer abstraction itself provides informtion requested of it.
    /// </remarks>
    public interface IGamer
    {
        /// <summary>
        /// Retrieves the gamer's name.
        /// </summary>
        /// <returns>A <see cref="String>"/>.</returns>
        string GetName();

        /// <summary>
        /// Retrieves the gamer's account score.
        /// </summary>
        /// <returns>An <see cref="Int32"/>.</returns>
        int GetScore();
    }
}
