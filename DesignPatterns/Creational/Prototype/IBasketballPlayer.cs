using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    public interface IBasketballPlayer : IPrototype<IBasketballPlayer>
    {
        string Name { get; set; }

        PositionType Position { get; set; }
    }
}
