using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    public class BasketballPlayerService
    {
        private IDictionary<PositionType, IBasketballPlayer> _prototypes;

        public BasketballPlayerService()
        {
            this._prototypes = new Dictionary<PositionType, IBasketballPlayer>();
        }

        public void RegisterPrototype(IBasketballPlayer playerPosition, PositionType position)
        {
            if(!this._prototypes.Keys.Contains(position))
            {
                this._prototypes.Add(position, playerPosition);
            }
        }

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
