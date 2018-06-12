namespace PMasta.LearnWithCode.DesignPatterns.Structural.Decorator.Players
{
	/// <summary>
	/// A concrete player.
	/// </summary>
	/// <remarks>
	/// This class fulfills the role of the Concrete Component.
	/// </remarks>
	public class BasicPlayer : IPlayer
	{
		public int Attack()
		{
			return 10;
		}

		public int Defend()
		{
			return 10;
		}
	}
}
