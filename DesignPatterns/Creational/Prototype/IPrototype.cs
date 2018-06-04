using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    public interface IPrototype<TType>
    {
        TType Clone();
    }
}
