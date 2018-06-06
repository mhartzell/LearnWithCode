using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Defines an interface for a video game player who also plays in a competitive space.
    /// </summary>
    /// <remarks>
    /// In the Bridge pattern, this interface serves as the role of the Refined Abstraction.  This is a more specific 
    /// gamer that inherits from the <see cref="IGamer"/> interface.
    /// </remarks>
    public interface ICompetitiveGamer : IGamer
    {
        long GetGlobalRanking();
    }
}
