using System;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// An interface defining a video game player that is relevant to a specific platform.
    /// </summary>
    /// <remarks>
    /// In the Bridge pattern, this interface takes on the role of the Implementor.  It is the base class of a separate 
    /// inheritance chain that can very independently of the chain started by <see cref="IGamer"/>.  Note that this interface
    /// varies significantly from <see cref="IGamer"/>.
    /// </remarks>
    public interface IPlatformGamer
    {
        string FirstName { get; set; }

        Object InternalId { get; set; }

        string LastName { get; set; }

        Platform Platform { get; set; }

        int AchievementRewardTotal();

        Object CalculateAccountScore();
    }
}
