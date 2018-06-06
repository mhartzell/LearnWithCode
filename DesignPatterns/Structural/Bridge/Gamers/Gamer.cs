using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Structural.Bridge.Gamers
{
    public class Gamer : IGamer
    {
        private IPlatformGamer _gamer;

        public Gamer(Platform platform)
        {
            // This is quick and dirty logic.  You would likely not want to actually instantiate 
            // these classes here, as it would create a tight coupling between the Abstraction 
            // hierarchy and the Implementor hierarchy.  You'd probably want a factory to provide 
            // an appropriate instance for you.
            switch (platform)
            {
                case Platform.Playstation4:
                    this._gamer = new PlaystationGamer("anemail@email.com");
                    break;

                case Platform.Steam:
                    this._gamer = new SteamGamer("anemail@email.com");
                    break;

                case Platform.XBox:
                    this._gamer = new XBoxGamer("anemail@email.com");
                    break;
            }
        }

        public string GetName()
        {
            return string.Format("{0} {1}", this._gamer.FirstName, this._gamer.LastName);
        }

        public int GetScore()
        {
            return Int32.Parse(this._gamer.CalculateAccountScore().ToString());
        }
    }
}
