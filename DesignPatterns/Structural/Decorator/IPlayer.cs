namespace PMasta.LearnWithCode.DesignPatterns.Structural.Decorator
{
	/// <summary>
	/// An interface defining a generic player in a game. 
	/// </summary>
	/// <remarks>
	/// This interfaces fulfills the role of the Component in the Decorator pattern. It defines an interface for objects
	/// that can have responsibilities added to them dynamically.
	/// </remarks>
	public interface IPlayer
    {
		/// <summary>
		/// Performs a standard attack.
		/// </summary>
		/// <returns>The strength of the attack.</returns>
		int Attack();

		/// <summary>
		/// Performs a standard defend.
		/// </summary>
		/// <returns>The strength of the defend.</returns>
		int Defend();
    }
}
