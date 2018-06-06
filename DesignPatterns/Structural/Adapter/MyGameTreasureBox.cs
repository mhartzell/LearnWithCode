using System;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// A custom treasure box specific to the game being created.
    /// </summary>
    /// <remarks>
    /// In the game my company is creating, we have built a custom treasure box.  We need to use this kind of treasure
    /// box because reasons.  We don't want to have to use the generic framework treasure box, but we still want to take
    /// advantages of the serivce the framework offers.
    /// </remarks>
    public class MyGameTreasureBox
    {
        public TreasureType GetTreasure()
        {
            Random r = new Random();

            return (TreasureType)(r.Next(0, 3));
        }
    }
}
