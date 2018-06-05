namespace PMasta.LearnWithCode.DesignPatterns.Creational.Singleton
{
	/// <summary>
	/// A class implementing the Single object creational pattern.
	/// </summary>
	/// <remarks>
	/// For some objects, only one instance should exist in the system.  A domain service is a great example.  The 
	/// Singleton pattern ensures a class has only one instance and also provides a global point of access to it.
	/// In this example, there should only be on instance of <see cref="WeaponFactory"/>, regardless of the chosen 
	/// implementation.
	/// </remarks>
	public class WeaponFactory
	{
		/// <summary>
		/// The Singleton instance.
		/// </summary>
		protected static WeaponFactory _instance;
		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <remarks>
		/// Is marked as protected to allow subclasses to further specify the Singleton instance.  Could also be marked private.
		/// </remarks>
		protected WeaponFactory()
		{

		}

		public static WeaponFactory Instance
		{
			// If no instance is created, make one.  Otherwise, return the instance.
			get
			{
				return _instance ?? (_instance = new WeaponFactory());
			}

			protected set { }
		}

		/// <summary>
		/// Some service the factory provides.
		/// </summary>
		/// <returns>Something.</returns>
		public object MakeWeapon()
		{
			return new object();
		}
	}
}
