namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// An interface defining the Factory Method class creational pattern.
    /// </summary>
    /// <remarks>
    /// The Factory Method pattern defines an interface for creating an object, but then lets subclasses decide
    /// which class to instantiate, deferring instantiation to those subclasses.  The Factory interface 
    /// defines factory methods that return Products.  If this were implemented as an abstract class, a default
    /// implementation of the factory methods could be provided.
    /// </remarks>
    public interface IWorldFactory
    {
        GameWorld ConstructWorld();
    }
}
