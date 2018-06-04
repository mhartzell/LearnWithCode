namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// An interface defining the Prototype object creational pattern.
    /// </summary>
    /// The Prototype pattern specifies the kinds of objects to create using a prototypical instance, 
    /// and then uses those prototypes to create new objects.  The key point is the implementation of
    /// the Clone method, which allows a Prototype to provide a copy of itself.  The Clone operation can
    /// be quite complex, depending on the complexity of the objects being cloned.
    /// <typeparam name="TType">The <see cref="Type"/> of the Prototype.</typeparam>
    public interface IPrototype<TType>
    {
        TType Clone();
    }
}
