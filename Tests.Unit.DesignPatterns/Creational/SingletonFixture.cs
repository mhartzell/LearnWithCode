using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.Learning.DesignPatterns.Creational.Singleton;

namespace PMasta.Learning.Tests.Unit.DesignPatterns.Creational
{
	/// <summary>
	/// Tests related to the Singleton pattern.
	/// </summary>
	[TestClass]
	public class SingletonFixture
    {
		[TestMethod]
		public void ConstructSucceeds()
		{
			// Compilation error because the constructor is inaccessible
			//WeaponFactory factory = new WeaponFactory();

			WeaponFactory factory = WeaponFactory.Instance;

			Assert.IsNotNull(factory);
		}

		[TestMethod]
		public void MultipleInstancesAreEqualSucceeds()
		{
			WeaponFactory factory1 = WeaponFactory.Instance;
			WeaponFactory factory2 = WeaponFactory.Instance;

			Assert.ReferenceEquals(factory1, factory2);
		}
    }
}
