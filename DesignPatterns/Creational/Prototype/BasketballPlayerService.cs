using System.Collections.Generic;

namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// A quick a dirty service for registering and instantiating Prototypes.
    /// </summary>
    public class BasketballPlayerService
    {
        private IDictionary<PositionType, IBasketballPlayer> _prototypes;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public BasketballPlayerService()
        {
            this._prototypes = new Dictionary<PositionType, IBasketballPlayer>();
        }

        /// <summary>
        /// Registers a new Prototype instance with the Prototype Registry.
        /// </summary>
        /// <param name="playerPrototype">The player Prototype.</param>
        /// <param name="position">The position to register the Prototype for.</param>
        public void RegisterPrototype(IBasketballPlayer playerPrototype, PositionType position)
        {
            if(!this._prototypes.Keys.Contains(position))
            {
                this._prototypes.Add(position, playerPrototype);
            }
        }

        /// <summary>
        /// Constructs a new <see cref="IBasketballPlayer"/> through the Prototype pattern.
        /// </summary>
        /// <param name="position">The requested position.</param>
        /// <param name="name">The name of the new player.</param>
        /// <returns>An <see cref="IBasketballPlayer>"/>.</returns>
        public IBasketballPlayer ConstructBasketballPlayer(PositionType position, string name)
        {
            IBasketballPlayer player = null;

            if (this._prototypes.ContainsKey(position))
            {
                player = this._prototypes[position].Clone();

                player.Name = name;
            }

            return player;
        }
    }
}
